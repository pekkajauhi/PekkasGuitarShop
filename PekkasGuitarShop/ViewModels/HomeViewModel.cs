using PekkasGuitarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Guitar> OffersOfTheWeek { get; set; }
    }
}
