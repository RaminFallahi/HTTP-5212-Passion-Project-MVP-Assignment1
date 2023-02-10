using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace passionProject1.Models
{
    public class category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }

    public class categoryDto
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}