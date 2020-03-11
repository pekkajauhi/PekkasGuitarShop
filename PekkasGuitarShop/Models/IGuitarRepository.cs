using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.Models
{
    public interface IGuitarRepository
    {
        IEnumerable<Guitar> AllGuitars { get; }
        IEnumerable<Guitar> OffersOfTheWeek { get; }
        Guitar GetGuitarById(int guitarId);
    }
}
