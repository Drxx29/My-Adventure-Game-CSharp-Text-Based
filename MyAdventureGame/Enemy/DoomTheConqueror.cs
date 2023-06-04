using System;

namespace MyAdventureGame
{
    class DoomTheConqueror : Enemy
    {
        public DoomTheConqueror()
        {
            Health = 1000;
            AttackPower = 100;
            Name = "Doom The Conqueror";
        }

        public override void Skill(Novice player)
        {
            Console.WriteLine("Hellzone Strike!");
            player.GetHit((int)0.33 * player.Health);
        }

        public override void BossSkill(Novice player)
        {
            player.GetHit(player.Health);
        }
    }
}
