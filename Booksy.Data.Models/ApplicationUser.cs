using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksy.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } 
        = new HashSet<Order>();
    }
}
