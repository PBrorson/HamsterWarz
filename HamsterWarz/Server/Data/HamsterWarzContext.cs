using HamsterWarz.Shared;
using Microsoft.EntityFrameworkCore;

namespace HamsterWarz.Server.Data
{
    public class HamsterWarzContext : DbContext
    {
        public HamsterWarzContext(DbContextOptions<HamsterWarzContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 1,
                Name = "Samuel",
                Age = 12,
                FavFood = "Pizza",
                Loves = "Gaming",
                ImgName = "hamster-1.jpg",


            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 2,
                Name = "Jonathan",
                Age = 44,
                FavFood = "Burgers",
                Loves = "Elden Ring",
                ImgName = "hamster-2.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 3,
                Name = "Elias",
                Age = 44,
                FavFood = "Pizza",
                Loves = "Sleeping",
                ImgName = "hamster-3.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 4,
                Name = "Johan",
                Age = 12,
                FavFood = "Broccoli",
                Loves = "Sports",
                ImgName = "hamster-4.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 5,
                Name = "Patrik",
                Age = 100,
                FavFood = "Shrimp",
                Loves = "Tacos",
                ImgName = "hamster-5.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 6,
                Name = "Sofia",
                Age = 30,
                FavFood = "HotDogs",
                Loves = "Nothing",
                ImgName = "hamster-6.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 7,
                Name = "Patricia",
                Age = 10,
                FavFood = "Cheese",
                Loves = "Running",
                ImgName = "hamster-7.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 8,
                Name = "Britta",
                Age = 33,
                FavFood = "Kebab",
                Loves = "Nothing",
                ImgName = "hamster-8.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 9,
                Name = "Patrik",
                Age = 100,
                FavFood = "Shrimp",
                Loves = "Tacos",
                ImgName = "hamster-9.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 10,
                Name = "Marshall",
                Age = 12,
                FavFood = "Shrimp",
                Loves = "Music",
                ImgName = "hamster-10.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 11,
                Name = "Greta",
                Age = 13,
                FavFood = "Cucumber",
                Loves = "Programming",
                ImgName = "hamster-11.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 12,
                Name = "FrankTheTank",
                Age = 15,
                FavFood = "Nachos",
                Loves = "Beer",
                ImgName = "hamster-12.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 13,
                Name = "Hammy",
                Age = 13,
                FavFood = "Carrots",
                Loves = "Dancing",
                ImgName = "hamster-13.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 14,
                Name = "FlipFlop",
                Age = 11,
                FavFood = "Rice",
                Loves = "Party",
                ImgName = "hamster-14.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 15,
                Name = "Mohammed",
                Age = 2,
                FavFood = "Falafel",
                Loves = "Dancing",
                ImgName = "hamster-15.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 16,
                Name = "Adam",
                Age = 37,
                FavFood = "Kebabtallrik",
                Loves = "Bowling",
                ImgName = "hamster-16.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 17,
                Name = "Johanna",
                Age = 2,
                FavFood = "Vegetables",
                Loves = "Formula1",
                ImgName = "hamster-17.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 18,
                Name = "Gerda",
                Age = 22,
                FavFood = "Candy",
                Loves = "Kanelbullar",
                ImgName = "hamster-18.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 19,
                Name = "Helen",
                Age = 18,
                FavFood = "Sushi",
                Loves = "Dancing",
                ImgName = "hamster-19.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 20,
                Name = "Totte",
                Age = 14,
                FavFood = "Burgers",
                Loves = "Beer",
                ImgName = "hamster-20.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 21,
                Name = "IPhone",
                Age = 2,
                FavFood = "Apple",
                Loves = "Movies",
                ImgName = "hamster-21.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 22,
                Name = "Coke",
                Age = 7,
                FavFood = "Mentos",
                Loves = "Bubbles",
                ImgName = "hamster-22.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 23,
                Name = "Blanca",
                Age = 49,
                FavFood = "Pizza",
                Loves = "Fighting",
                ImgName = "hamster-23.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 24,
                Name = "Jethro",
                Age = 66,
                FavFood = "BiffRydberg",
                Loves = "Music",
                ImgName = "hamster-24.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 25,
                Name = "SamTheMan",
                Age = 4,
                FavFood = "BeefTartar",
                Loves = "Women",
                ImgName = "hamster-25.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 26,
                Name = "Vinnie",
                Age = 42,
                FavFood = "Italian",
                Loves = "Family",
                ImgName = "hamster-26.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 27,
                Name = "Dexter",
                Age = 20,
                FavFood = "Meat",
                Loves = "People",
                ImgName = "hamster-27.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 28,
                Name = "Ken",
                Age = 22,
                FavFood = "Salad",
                Loves = "Barbie",
                ImgName = "hamster-28.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 29,
                Name = "Johnny",
                Age = 39,
                FavFood = "Pizza",
                Loves = "Amber Heard",
                ImgName = "hamster-29.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 30,
                Name = "Linus",
                Age = 9,
                FavFood = "PadThai",
                Loves = "Gaming",
                ImgName = "hamster-30.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 31,
                Name = "Batman",
                Age = 13,
                FavFood = "PyttiPanna",
                Loves = "Robin",
                ImgName = "hamster-31.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 32,
                Name = "Joker",
                Age = 11,
                FavFood = "Carrots",
                Loves = "Batman",
                ImgName = "hamster-32.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 33,
                Name = "Biro",
                Age = 55,
                FavFood = "FriedRice",
                Loves = "Soda",
                ImgName = "hamster-33.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 34,
                Name = "Urkel",
                Age = 9,
                FavFood = "Waffles",
                Loves = "Cars",
                ImgName = "hamster-34.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 35,
                Name = "Rambo",
                Age = 4,
                FavFood = "Snake",
                Loves = "Explosions",
                ImgName = "hamster-35.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 36,
                Name = "Jim",
                Age = 1,
                FavFood = "Worms",
                Loves = "Running",
                ImgName = "hamster-36.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 37,
                Name = "Ross",
                Age = 30,
                FavFood = "Sandwiches",
                Loves = "Rachel",
                ImgName = "hamster-37.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 38,
                Name = "Blazor",
                Age = 11,
                FavFood = "Spaghetti",
                Loves = "Computers",
                ImgName = "hamster-38.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 39,
                Name = "Joey",
                Age = 10,
                FavFood = "Lasagna",
                Loves = "Women",
                ImgName = "hamster-39.jpg",

            });
            modelbuilder.Entity<Hamster>().HasData(new Hamster
            {
                Id = 40,
                Name = "Clark",
                Age = 21,
                FavFood = "Cryptonite",
                Loves = "Lois",
                ImgName = "hamster-40.jpg",

            });


        }
        public DbSet<Hamster> Hamsters { get; set; }
    }

}
