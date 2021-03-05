using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiqourCentre.Models
{
    //this is model class for table product
    public class Product  
    {
        public int ID { get; set; } //primary key
        public int BrandID { get; set; }//ID come from brand table
        public Brand Brand { get; set; }//Navigation for brand table
        public string name { get; set; }
        public int price { get; set; }
        public string liter { get; set; }

    }
}
