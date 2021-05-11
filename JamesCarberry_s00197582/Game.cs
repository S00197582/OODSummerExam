using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesCarberry_s00197582
{
    class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public double Price { get; set; }
        public string Game_Image { get; set; }


        public void DecreasePrice(double priceDrop)
        {
            Price = Price - priceDrop;
        }


    }
}
