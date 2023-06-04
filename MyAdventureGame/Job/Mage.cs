using System;

namespace MyAdventureGame
{
    class Mage : Novice
    {
        public int Mana { get; set; }

        public Mage()
        {
            Health = 200;
            AttackPower = 15;
            Mana = 0;
        }

        public override void Skill(Enemy enemy)
        {
            if(Mana>=10)
            {
                Console.WriteLine("Fireball!");
                Console.WriteLine("Burn it All!");
                enemy.GetHit(AttackPower + 100);
                Mana = 0;
            }else
            {
                Console.WriteLine("Mana : "+Mana);
                Console.WriteLine("You don't have enough mana");
                
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating mana");
            Mana+=2;
        }
    }
}