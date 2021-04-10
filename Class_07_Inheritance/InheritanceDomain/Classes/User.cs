using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDomain.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
    }
}
