using System;
using System.Collections.Generic;

namespace EmployeeOrders.Web.Models
{
	public partial class Drink
    {
        public Drink()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
