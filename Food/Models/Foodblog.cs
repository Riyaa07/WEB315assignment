using System;
using System.ComponentModel.DataAnnotations;

namespace Foodblog.Models
{
    public class Foodie
    {
        public int ID { get; set;}
        public string Name { get; set;} //this is an auto property
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set;}
        public string Ingredients { get; set;}
        public decimal Price { get; set;}
    }
}