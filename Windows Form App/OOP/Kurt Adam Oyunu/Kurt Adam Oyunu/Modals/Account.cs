using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurt_Adam_Oyunu.Modals
{
    internal class Account
    {

        public string userName { get; set; }
        public string race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }

        Random random = new Random();
        public void Attack()
        {
            damage = 0;
            /* 
              Irk => human +5, monster +10
              Warrior = > 40 dmg
              Mage => 30 - 50 dmg
              Assasin => 10 - 70 dmg
              Archer => 5 - 60 dmg
             */
            if (race == "Human")
            {
                damage += 5;
            }
            else
            {
                damage += 10;
            }

            if (branch == "Warrior")
            {
                damage += 40;
            }else if (branch == "Mage")
            {
                damage += random.Next(30, 51);
            }else if (branch == "Assasin")
            {
                damage += random.Next(10, 70);
            }else if (branch == "Archer")
            {
                int number = random.Next(0,2);
                damage += number == 0 ? 5 : 60; // kısa if else
            }
        }
    }
}
