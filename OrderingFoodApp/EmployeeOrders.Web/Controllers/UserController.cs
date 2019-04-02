using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EmployeeOrders.Web.Models;
using EmployeeOrders.Web.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeOrders.Web.Controllers
{
	public class UserController : Controller
	{
		private EmployeeOrdersContext _context;

		public UserController(EmployeeOrdersContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous, HttpGet]
		public async Task<IActionResult> Register()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			return View();
		}

		[AllowAnonymous, HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (!ModelState.IsValid)
				throw new Exception("Invalid registration information");

			model.Name = model.Name.Trim();
			model.Password = model.Password.Trim();
			model.RepeatPassword = model.RepeatPassword.Trim();

			var targetUser = _context.User.SingleOrDefault(u => u.Name.Equals(model.Name, StringComparison.InvariantCultureIgnoreCase));

			if (targetUser != null)
				throw new Exception("User already exists");

			if (!model.Password.Equals(model.RepeatPassword))
				throw new Exception("Passwords are not the same");

			var hasher = new PasswordHasher<User>();

			targetUser = new User
			{
				Name = model.Name,
				PasswordHash = hasher.HashPassword(targetUser, model.Password),
				Department = model.Department,
				IsPurchaser = false,
				IsAdmin = false
			};


			if (_context.User.Count() == 0)
				targetUser.IsAdmin = true;

			if (_context.User.Count() == 1)
				targetUser.IsPurchaser = true;

			await _context.User.AddAsync(targetUser);
			await _context.SaveChangesAsync();
			await LogInAsync(targetUser);

			return RedirectToAction("Index", "Home");
		}

		private async Task LogInAsync(User user)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user.Name)
			};
			if (user.IsAdmin)
			{
				claims.Add(new Claim(ClaimTypes.Role, Roles.Administrator));
			}
			if (user.IsPurchaser)
			{
				claims.Add(new Claim(ClaimTypes.Role, Roles.Purchaser));
			}

			var claimsIndentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var claimsPrincipal = new ClaimsPrincipal(claimsIndentity);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
			await _context.SaveChangesAsync();
		}

		[AllowAnonymous, HttpGet]
		public async Task<IActionResult> LogIn()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			return View();
		}

		[AllowAnonymous, HttpPost]
		public async Task<IActionResult> LogIn(LogInViewModel model)
		{
			if (!ModelState.IsValid)
				throw new Exception("Invalid registration information");

			model.Name = model.Name.Trim();
			model.Password = model.Password.Trim();

			var targetUser = _context.User.SingleOrDefault(u => u.Name == model.Name);
			if (targetUser == null)
				throw new Exception("User does not exist");

			var hasher = new PasswordHasher<User>();

			if (hasher.VerifyHashedPassword(targetUser, targetUser.PasswordHash, model.Password) == PasswordVerificationResult.Success)
			{
				await LogInAsync(targetUser);

				return RedirectToAction("Index", "Home");
			}
			else
				throw new Exception("The Password is wrong");
		}

		[HttpGet]
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult MakeOrder()
		{
			if (!User.Identity.IsAuthenticated)
				return RedirectToAction("LogIn", "User");


			return View();
		}

		[HttpPost]
		public async Task<IActionResult> MakeOrder(OrderViewModel model)
		{
			var user = _context.User.SingleOrDefault(u => u.Name == User.Identity.Name);

			var drink = _context.Drink.SingleOrDefault(d => d.Id == model.Drink_Id);
			var food = _context.Food.SingleOrDefault(f => f.Id == model.Food_Id);

			var order = new Order()
			{
				DrinkId = drink.Id,
				FoodId = food.Id,
				Total = food.Price + drink.Price
			};

			await _context.Order.AddAsync(order);
			await _context.SaveChangesAsync();

			var userOrder = new UserOrders()
			{
				UserId = user.Id,
				OrderId = order.Id,
				Date = DateTime.Now,
				Order = order
			};

			await _context.UserOrders.AddAsync(userOrder);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Home");
		}

		[HttpGet, Authorize(Roles = Roles.Purchaser)]
		public IActionResult Orders(bool sort = false)
		{

			var orders = _context.UserOrders.Include("User")
				.Include(o => o.Order).ThenInclude(f => f.Food)
				.Include(o => o.Order).ThenInclude(d => d.Drink)
				.ToList();

			if (sort)
				orders = orders.Where(o => o.Date.Day == DateTime.Today.Day).ToList();

			ViewBag.totalPrice = orders.Sum(o => o.Order.Total);
			//grouping drinks
			ViewBag.totalDrinks = orders.GroupBy(f => f.Order.Drink.Name)
									  .Select(g => new Product()
									  {
										  Name = g.Key,
										  Count = g.Count()
									  }).ToList();
			//grouping food
			ViewBag.totalFood = orders.GroupBy(f => f.Order.Food.Name)
									  .Select(g => new Product()
									  {
										  Name = g.Key,
										  Count = g.Count()
									  }).ToList();
			return View(orders);
		}

		[HttpGet, Authorize(Roles = Roles.Administrator)]
		public IActionResult Users()
		{
			var users = _context.User.ToList();
			return View(users);
		}
	}
}
