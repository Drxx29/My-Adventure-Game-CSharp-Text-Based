using System;

namespace MyAdventureGame
{
    class Battler : Enemy
    {
        //The winged servants of evil with slight gas issues.
        public Battler()
        {
            Health = 50;
            AttackPower = 9;
            Name = "Battler";
            
        }

        public override void Skill(Novice player)
        {
            Console.WriteLine("Sonic Scream!!!");
            player.GetHit(3 * AttackPower);
        }
    }
}