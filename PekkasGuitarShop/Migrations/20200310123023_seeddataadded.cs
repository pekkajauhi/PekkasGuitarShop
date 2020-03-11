using Microsoft.EntityFrameworkCore.Migrations;

namespace PekkasGuitarShop.Migrations
{
    public partial class seeddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Acoustic Guitars", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Classical Guitars", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Electric Guitars", null });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "GuitarId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsOfferOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://i.imgur.com/Mw7TTCJ.png", "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Yamaha", null, 199.95m, "Lorem Ipsum" },
                    { 3, 1, "https://i.imgur.com/Mw7TTCJ.png", "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Ibanez", null, 149.95m, "Lorem Ipsum" },
                    { 6, 1, "https://i.imgur.com/Mw7TTCJ.png", "https://images.pexels.com/photos/2021348/pexels-photo-2021348.jpeg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Fender", null, 249.95m, "Lorem Ipsum" },
                    { 7, 1, "https://i.imgur.com/Mw7TTCJ.png", "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Hagström", null, 399.95m, "Lorem Ipsum" },
                    { 8, 1, "https://i.imgur.com/Mw7TTCJ.png", "https://images.pexels.com/photos/164729/pexels-photo-164729.jpeg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Takamine", null, 299.95m, "Lorem Ipsum" },
                    { 2, 2, "https://i.imgur.com/6JUR07N.png", "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Landola", null, 99.95m, "Lorem Ipsum" },
                    { 9, 2, "https://i.imgur.com/6JUR07N.png", "https://images.pexels.com/photos/3740567/pexels-photo-3740567.jpeg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Landola", null, 99.95m, "Lorem Ipsum" },
                    { 4, 3, "https://i.imgur.com/a2RaVuI.png", "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Tokai", null, 459.95m, "Lorem Ipsum" },
                    { 5, 3, "https://i.imgur.com/a2RaVuI.png", "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Yamaha", null, 199.95m, "Lorem Ipsum" },
                    { 10, 3, "https://i.imgur.com/a2RaVuI.png", "https://images.pexels.com/photos/2156327/pexels-photo-2156327.jpeg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ac varius metus. Aenean vitae finibus justo. Vestibulum eleifend mauris a vulputate pulvinar. Maecenas non nisl congue, consectetur mi ac, vulputate velit. Phasellus pulvinar tristique gravida. Curabitur pretium auctor tempor. Donec volutpat ultricies massa, vel sodales enim semper eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin id semper mauris.", "Fender", null, 499.95m, "Lorem Ipsum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
