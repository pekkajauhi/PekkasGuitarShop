using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PekkasGuitarShop.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Acoustic Guitars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Classical Guitars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Electric Guitars" });

            //seed pies

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 1,
                Name = "Yamaha",
                Price = 199.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 1,
                ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                InStock = true,
                IsOfferOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 2,
                Name = "Landola",
                Price = 99.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 2,
                ImageUrl = "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg",
                InStock = true,
                IsOfferOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/6JUR07N.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 3,
                Name = "Ibanez",
                Price = 149.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 1,
                ImageUrl = "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg",
                InStock = true,
                IsOfferOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 4,
                Name = "Tokai",
                Price = 459.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 3,
                ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                InStock = true,
                IsOfferOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 5,
                Name = "Yamaha",
                Price = 199.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 3,
                ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                InStock = true,
                IsOfferOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 6,
                Name = "Fender",
                Price = 249.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 1,
                ImageUrl = "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg",
                InStock = true,
                IsOfferOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 7,
                Name = "Hagström",
                Price = 399.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 1,
                ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                InStock = true,
                IsOfferOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 8,
                Name = "Takamine",
                Price = 299.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 1,
                ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                InStock = true,
                IsOfferOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png"
            });


            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 9,
                Name = "Landola",
                Price = 99.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 2,
                ImageUrl = "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg",
                InStock = true,
                IsOfferOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/6JUR07N.png"
            });

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 10,
                Name = "Fender",
                Price = 499.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                CategoryId = 3,
                ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                InStock = true,
                IsOfferOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png"
            });
        }
    }
}
