using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Fighter{
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Spead { get; set; }
        public int Rating { get; set; }
    }

    public class Boost
    {
        public string Name { get; set; }
        public int Boostdamage { get; set; }
        public int Boostspead { get; set; }
        public int Boostrating { get; set; }
    }

    public class Player : Fighter
    {
        public Player(string name, int damage ,int spead,int rating)
        {
            this.Name = name;
            this.Damage = damage;
            this.Spead = spead;
            this.Rating = rating;
        }
    }

    public class Jegernaut : Fighter
    {   
        public int Level { get; set;}

        public Jegernaut( int damage, int spead, int rating,int level)
        {
            this.Level = level;
            this.Name = "Jegernaut";
            this.Damage = damage;
            this.Spead = spead;
            this.Rating = rating;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
