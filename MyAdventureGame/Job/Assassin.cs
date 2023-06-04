using System;

namespace MyAdventureGame
{
     class Assassin : Novice
    {
        public int HitCombo{ get; set; }
        Random rnd = new Random();

        public Assassin(){
            Health = 300;
            AttackPower = 5;
            HitCombo = 0;
        }

        public override void Skill(Enemy enemy)
        {
            if(HitCombo >= 4){
                Console.WriteLine("Stealth Strike!");
                for(int i=0;i<=HitCombo;i++){
                    Console.WriteLine("Shadow slash!");
                    enemy.GetHit(AttackPower + rnd.Next(3,10));
                }HitCombo = 0;
            }else
            {
                Console.WriteLine("Hit Combo : "+HitCombo);
                Console.WriteLine("You need to regenerate your combo");
                
            }
        }

        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Generating rage...");
            HitCombo++;
        }


    }
}