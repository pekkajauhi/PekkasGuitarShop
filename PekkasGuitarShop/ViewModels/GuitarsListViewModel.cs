using PekkasGuitarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.ViewModels
{
    public class GuitarsListViewModel
    {
        public IEnumerable<Guitar> Guitars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
