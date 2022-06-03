using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarz.Server.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 12, "Pizza", 0, "hamster-1.jpg", 0, "Gaming", "Samuel", 0 },
                    { 2, 44, "Burgers", 0, "hamster-2.jpg", 0, "Elden Ring", "Jonathan", 0 },
                    { 3, 44, "Pizza", 0, "hamster-3.jpg", 0, "Sleeping", "Elias", 0 },
                    { 4, 12, "Broccoli", 0, "hamster-4.jpg", 0, "Sports", "Johan", 0 },
                    { 5, 100, "Shrimp", 0, "hamster-5.jpg", 0, "Tacos", "Patrik", 0 },
                    { 6, 30, "HotDogs", 0, "hamster-6.jpg", 0, "Nothing", "Sofia", 0 },
                    { 7, 10, "Cheese", 0, "hamster-7.jpg", 0, "Running", "Patricia", 0 },
                    { 8, 33, "Kebab", 0, "hamster-8.jpg", 0, "Nothing", "Britta", 0 },
                    { 9, 100, "Shrimp", 0, "hamster-9.jpg", 0, "Tacos", "Patrik", 0 },
                    { 10, 12, "Shrimp", 0, "hamster-10.jpg", 0, "Music", "Marshall", 0 },
                    { 11, 13, "Cucumber", 0, "hamster-11.jpg", 0, "Programming", "Greta", 0 },
                    { 12, 15, "Nachos", 0, "hamster-12.jpg", 0, "Beer", "FrankTheTank", 0 },
                    { 13, 13, "Carrots", 0, "hamster-13.jpg", 0, "Dancing", "Hammy", 0 },
                    { 14, 11, "Rice", 0, "hamster-14.jpg", 0, "Party", "FlipFlop", 0 },
                    { 15, 2, "Falafel", 0, "hamster-15.jpg", 0, "Dancing", "Mohammed", 0 },
                    { 16, 37, "Kebabtallrik", 0, "hamster-16.jpg", 0, "Bowling", "Adam", 0 },
                    { 17, 2, "Vegetables", 0, "hamster-17.jpg", 0, "Formula1", "Johanna", 0 },
                    { 18, 22, "Candy", 0, "hamster-18.jpg", 0, "Kanelbullar", "Gerda", 0 },
                    { 19, 18, "Sushi", 0, "hamster-19.jpg", 0, "Dancing", "Helen", 0 },
                    { 20, 14, "Burgers", 0, "hamster-20.jpg", 0, "Beer", "Totte", 0 },
                    { 21, 2, "Apple", 0, "hamster-21.jpg", 0, "Movies", "IPhone", 0 },
                    { 22, 7, "Mentos", 0, "hamster-22.jpg", 0, "Bubbles", "Coke", 0 },
                    { 23, 49, "Pizza", 0, "hamster-23.jpg", 0, "Fighting", "Blanca", 0 },
                    { 24, 66, "BiffRydberg", 0, "hamster-24.jpg", 0, "Music", "Jethro", 0 },
                    { 25, 4, "BeefTartar", 0, "hamster-25.jpg", 0, "Women", "SamTheMan", 0 },
                    { 26, 42, "Italian", 0, "hamster-26.jpg", 0, "Family", "Vinnie", 0 },
                    { 27, 20, "Meat", 0, "hamster-27.jpg", 0, "People", "Dexter", 0 },
                    { 28, 22, "Salad", 0, "hamster-28.jpg", 0, "Barbie", "Ken", 0 },
                    { 29, 39, "Pizza", 0, "hamster-29.jpg", 0, "Amber Heard", "Johnny", 0 },
                    { 30, 9, "PadThai", 0, "hamster-30.jpg", 0, "Gaming", "Linus", 0 },
                    { 31, 13, "PyttiPanna", 0, "hamster-31.jpg", 0, "Robin", "Batman", 0 },
                    { 32, 11, "Carrots", 0, "hamster-32.jpg", 0, "Batman", "Joker", 0 },
                    { 33, 55, "FriedRice", 0, "hamster-33.jpg", 0, "Soda", "Biro", 0 },
                    { 34, 9, "Waffles", 0, "hamster-34.jpg", 0, "Cars", "Urkel", 0 },
                    { 35, 4, "Snake", 0, "hamster-35.jpg", 0, "Explosions", "Rambo", 0 },
                    { 36, 1, "Worms", 0, "hamster-36.jpg", 0, "Running", "Jim", 0 },
                    { 37, 30, "Sandwiches", 0, "hamster-37.jpg", 0, "Rachel", "Ross", 0 },
                    { 38, 11, "Spaghetti", 0, "hamster-38.jpg", 0, "Computers", "Blazor", 0 },
                    { 39, 10, "Lasagna", 0, "hamster-39.jpg", 0, "Women", "Joey", 0 },
                    { 40, 21, "Cryptonite", 0, "hamster-40.jpg", 0, "Lois", "Clark", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
