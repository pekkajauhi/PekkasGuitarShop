﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PekkasGuitarShop.Models;

namespace PekkasGuitarShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Acoustic Guitars"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Classical Guitars"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Electric Guitars"
                        });
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.Guitar", b =>
                {
                    b.Property<int>("GuitarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOfferOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuitarId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Guitars");

                    b.HasData(
                        new
                        {
                            GuitarId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png",
                            ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = false,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Yamaha",
                            Price = 199.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://i.imgur.com/6JUR07N.png",
                            ImageUrl = "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = false,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Landola",
                            Price = 99.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 3,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png",
                            ImageUrl = "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Ibanez",
                            Price = 149.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 4,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png",
                            ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Tokai",
                            Price = 459.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 5,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png",
                            ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Yamaha",
                            Price = 199.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 6,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png",
                            ImageUrl = "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Fender",
                            Price = 249.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 7,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png",
                            ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = false,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Hagström",
                            Price = 399.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 8,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/Mw7TTCJ.png",
                            ImageUrl = "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = false,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Takamine",
                            Price = 299.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 9,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://i.imgur.com/6JUR07N.png",
                            ImageUrl = "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = false,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Landola",
                            Price = 99.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            GuitarId = 10,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.imgur.com/a2RaVuI.png",
                            ImageUrl = "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg",
                            InStock = true,
                            IsOfferOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.",
                            Name = "Fender",
                            Price = 499.95m,
                            ShortDescription = "Lorem Ipsum"
                        });
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GuitarId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("GuitarId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("GuitarId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("GuitarId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.Guitar", b =>
                {
                    b.HasOne("PekkasGuitarShop.Models.Category", "Category")
                        .WithMany("Guitars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.OrderDetail", b =>
                {
                    b.HasOne("PekkasGuitarShop.Models.Guitar", "Guitar")
                        .WithMany()
                        .HasForeignKey("GuitarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PekkasGuitarShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PekkasGuitarShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("PekkasGuitarShop.Models.Guitar", "Guitar")
                        .WithMany()
                        .HasForeignKey("GuitarId");
                });
#pragma warning restore 612, 618
        }
    }
}
