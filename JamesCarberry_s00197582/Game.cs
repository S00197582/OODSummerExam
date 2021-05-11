using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesCarberry_s00197582
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public double Price { get; set; }
        public string Game_Image { get; set; }

        public Game()
        {

        }

        public Game(double price)
        {
            Price = price;
        }

        public Game(string name, int score, string description, string platform, double price, string game_image)
        {
            Name = name;
            Score = score;
            Description = description;
            Platform = platform;
            Price = price;
            Game_Image = game_image;
        }


        public void DecreasePrice(double priceDrop)
        {
            Price = Price - priceDrop;
        }


    }

    public class GameData : DbContext
    {
        public GameData() : base("GameData") { } //db name

        public DbSet<Game> Games { get; set; } //create game table
    }





}
