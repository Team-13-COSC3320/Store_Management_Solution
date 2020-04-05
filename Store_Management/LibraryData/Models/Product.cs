using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management.LibraryData.Models
{
    public class Product
    {
        //id, name, category, image, price, description
        [Key]
        public int P_ID { get; set; }
        public string P_Name { get; set; }

        public string P_Category { get; set; }

        //this is going to be how I do photos
        public string photoPath { get; set; }

        public int P_Price { get; set; }

        public string P_Description { get; set; }
    }
}
