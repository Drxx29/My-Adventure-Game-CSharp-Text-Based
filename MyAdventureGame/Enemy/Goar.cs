using System;

namespace MyAdventureGame
{
    class Goar : Enemy
    {
        //Huge powerful jaws, terrible breath, and unstoppable power. This guy is like a bad hair day brought to life.
        public Goar()
        {
            Health = 200;
            AttackPower = 30;
            Name = "Goar";
            
        }

         public override void Skill(Novice player)
        {
            Console.WriteLine("Hundred Stomp!");
            player.GetHit(4 * AttackPower);
        }
    }
}