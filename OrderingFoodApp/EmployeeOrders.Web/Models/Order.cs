using System;
using System.Collections.Generic;

namespace EmployeeOrders.Web.Models
{
	public partial class Order
    {
        public Order()
        {
            UserOrders = new HashSet<UserOrders>();
        }

        public int Id { get; set; }
        public int? DrinkId { get; set; }
        public int? FoodId { get; set; }
        public decimal Total { get; set; }

        public virtual Drink Drink { get; set; }
        public virtual Food Food { get; set; }
        public virtual ICollection<UserOrders> UserOrders { get; set; }
    }
}
