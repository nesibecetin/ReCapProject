using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
