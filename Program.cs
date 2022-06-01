using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Batle
    {

    }

    class Platoon
    {
        private List<Soldier> soldiersGood = new List<Soldier>();
        private List<Soldier> soldiersBad = new List<Soldier>();

        public void Creation()
        {

        }
    }


    class Soldier
    {
        private Random random = new Random();

        public int Healts { get; private set; }
        public int Damage { get; private set; }
        public int Armor { get; private set; }

        public Soldier()
        {
            CreateHealth();
            CreateDamage();
            CreateArmor();
        }

        private void CreateHealth()
        {
            int minHealth = 90;
            int maxHealth = 120;

            Healts = random.Next(minHealth, maxHealth);
        }

        private void CreateDamage()
        {
            int minDamage = 10;
            int maxDamage = 25;

            Damage = random.Next(minDamage, maxDamage);
        }

        private void CreateArmor()
        {
            int minArmor = 1;
            int maxArmor = 10;

            Armor = random.Next(minArmor, maxArmor);
        }
    }
}
