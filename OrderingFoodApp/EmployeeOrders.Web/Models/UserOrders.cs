using System;
using System.Collections.Generic;

namespace EmployeeOrders.Web.Models
{
	public partial class UserOrders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }

        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
