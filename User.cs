using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_Models
{
    public class User
    {
        public int U_Id { get; set; }
        public string U_FirstName { get; set; }
        public string U_LastName { get; set; }
        public string U_Address { get; set; }
        public string U_Country { get; set; }
        public string U_Zipcode { get; set; }
        public string U_Phone { get; set; }
        public string U_Email { get; set; }
        public UserRole? U_Role { get; set; }
    }
}
