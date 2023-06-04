using System;

namespace MyAdventureGame
{
    class Marksman : Novice
    {
        public int Energy { get; set; }

        public Marksman()
        {
            Health = 300;
            AttackPower = 10;
            Energy = 0;
        }

        public override void Skill(Enemy enemy)
        {
           if(Energy>=10)
           {
               Console.WriteLine("Quick Draw!");
               for(int i=0;i<=Energy;i+=2)
               {
                   Console.WriteLine("One Tap Shot!");
               }
               enemy.GetHit(5 * AttackPower);
               Energy = 0;
           }else
           {
               Console.WriteLine("Energy : "+Energy);
               Console.WriteLine("You need more energy");
               
           }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating energy...");
            Energy+=5;
        }
    }
}