﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryData.Models
{
    public class Review
    {
        [Key]
        public int R_ID { get; set; }
        public int R_UID { get; set; }
        public string R_Title { get; set; }
        public string R_Content { get; set; }
        public int R_Star { get; set; }

        [ForeignKey("Product")]
        public int P_ID {get; set;}
    }

}



