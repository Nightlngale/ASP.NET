using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrders.Web.Models.ViewModels
{
	public class OrderViewModel
	{
		[DisplayName("Food")]
		public int Food_Id { get; set; }
		[DisplayName("Drink")]
		public int Drink_Id { get; set; }
	}
}