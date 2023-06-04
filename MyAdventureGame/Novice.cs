using System;

namespace MyAdventureGame
{
    class Novice
    {//skillslot???
       public int Health { get; set; } 
       public string Name { get; set; }
       public int AttackPower { get; set; }
       public bool IsDead { get; set; }
       public float Experience { get; set; }
       public bool IsRunningAway { get; set; }
       Random rnd = new Random();

       public Novice(){
           Health = 100;
           AttackPower = 3;
           Experience = 0.0f;
       }

       public void RunningAway(){
           IsRunningAway = true;
           IsDead = true;
       }

       public virtual void Skill(Enemy enemy)
       {
           Console.WriteLine("Jab!");
           AttackPower = 10;
           enemy.GetHit(AttackPower);
       }

       public virtual void Defend()
       {
           Console.WriteLine("Defend");
       }

       public void GetHit(int hitValue)
       {
           Console.WriteLine("You get hit by "+hitValue);
           Health = Health - hitValue;// Health -= hitValue;
          
           if(Health <= 0)
           {
               Health = 0;
               Die();
           }
       }

       public void Die()
       {
           Console.WriteLine("You are dead. Game Over");
           IsDead = true; 
       }





    }
}
