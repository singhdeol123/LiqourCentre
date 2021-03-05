using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiqourCentre.Models
{
    public class Wine //model for wine pages
    {
        public int ID { get; set; } //primary key
       //other variables
        public string name { get;set; }
        public int price { get; set; }
    }
}
