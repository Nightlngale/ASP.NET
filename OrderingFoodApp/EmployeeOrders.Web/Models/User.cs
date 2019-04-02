using System;
using System.Collections.Generic;

namespace EmployeeOrders.Web.Models
{
	public partial class User
    {
        public User()
        {
            UserOrders = new HashSet<UserOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string Department { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsPurchaser { get; set; }

        public virtual ICollection<UserOrders> UserOrders { get; set; }
    }
}
