using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class User
    {
        [Key]
        public int U_Id { get; set; }
        public string U_Pass { get; set; }
        public string U_FirstName { get; set; }
        public string U_LastName { get; set; }
        public string U_Address { get; set; }
        public string U_Country { get; set; }
        public int U_Zipcode { get; set; }
        public string U_Phone { get; set; }
        public string U_Email { get; set; }
        public string U_Role { get; set; }

        //public virtual LibraryCard LibraryCard { get; set; }
    }
}
