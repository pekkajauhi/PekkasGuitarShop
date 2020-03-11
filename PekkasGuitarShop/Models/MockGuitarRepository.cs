using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.Models
{
    public class MockGuitarRepository: IGuitarRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Guitar> AllGuitars =>
            new List<Guitar>
             {
                new Guitar {GuitarId = 1, Name="Yamaha", Price=199.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg", InStock=true, IsOfferOfTheWeek=false, ImageThumbnailUrl="https://i.imgur.com/Mw7TTCJ.png"},
                new Guitar {GuitarId = 2, Name="Landola", Price=99.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg", InStock=true, IsOfferOfTheWeek=false, ImageThumbnailUrl="https://i.imgur.com/6JUR07N.png"},
                new Guitar {GuitarId = 3, Name="Ibanez", Price=149.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg", InStock=true, IsOfferOfTheWeek=true, ImageThumbnailUrl="https://i.imgur.com/Mw7TTCJ.png"},
                new Guitar {GuitarId = 4, Name="Fender", Price=499.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg", InStock=true, IsOfferOfTheWeek=true, ImageThumbnailUrl="https://i.imgur.com/a2RaVuI.png"}
            };

        public IEnumerable<Guitar> OffersOfTheWeek { get; }

        public Guitar GetGuitarById(int guitarId)
        {
            return AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);
        }
    }
}
