using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace passionProject1.Models
{
    public class place
    {
        [Key]
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }


        //one place belongs to a season to go
        //one season belongs to many places
        [ForeignKey("BestSeasonToGo")]
        public int BestSeasonToGoID { get; set; }
        public virtual BestSeasonToGo BestSeasonToGo { get; set; }


        //one place belongs to a category
        //one category belongs to many places
        [ForeignKey("category")]
        public int categoryID { get; set; }
        public virtual category category { get; set; }
    }

    //DATA TRANSFER OBJECT METHOD:
    public class placeDto
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public string BestSeasonToGoID { get; set; }
        public string categoryID { get; set; }


    }
}