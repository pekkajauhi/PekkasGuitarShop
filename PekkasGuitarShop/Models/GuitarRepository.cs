using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.Models
{
    public class GuitarRepository: IGuitarRepository
    {
        private readonly AppDbContext _appDbContext;

        public GuitarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Guitar> AllGuitars
        {
            get
            {
                return _appDbContext.Guitars.Include(c => c.Category);
            }
        }

        public IEnumerable<Guitar> OffersOfTheWeek
        {
            get
            {
                return _appDbContext.Guitars.Include(c => c.Category).Where(p => p.IsOfferOfTheWeek);
            }
        }

        public Guitar GetGuitarById(int guitarId)
        {
            return _appDbContext.Guitars.FirstOrDefault(g => g.GuitarId == guitarId);
        }
    }
}
