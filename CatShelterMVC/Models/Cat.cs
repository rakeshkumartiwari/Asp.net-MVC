using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShelterMVC.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string City { get; set; }
    }
}