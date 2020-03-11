using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.Models
{
    public class Guitar
    {
        public int GuitarId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOfferOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Notes { get; set; }


    }
}
