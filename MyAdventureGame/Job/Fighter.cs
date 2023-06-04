using System;

namespace MyAdventureGame
{
    class Fighter : Novice
    {
        public int Rage { get; set; }
        public static int StunDuration = 3;

        public Fighter()
        {
            Health = 500;
            AttackPower = 9;
            Rage = 0;
        }

        public override void Skill(Enemy enemy)
        {
            
            if(Rage >= 3){
                StunDuration = 3;
                Console.WriteLine("Heavy Strike!");
                Console.WriteLine("Knockout Punch!");
                Console.WriteLine(enemy.Name+ " is being stunned for "+StunDuration+ " seconds.");
                enemy.IsStunned = true;
                enemy.GetHit(3 * AttackPower);
                Rage = 0;
            }else{
                Console.WriteLine("Rage : "+Rage);
                Console.WriteLine("You don't have enough rage.");
                
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating rage...");
            Rage++;
        }


    }
}