using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLTE.Models
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }

    }
}