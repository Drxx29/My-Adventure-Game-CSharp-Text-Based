using System;

namespace MyAdventureGame
{
    class Enemy
    {
        public int Health { get; set; } 
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public bool IsStunned { get; set; }
        Random rnd = new Random();

        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name+" get hit by " +hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }  

        public void Die()
       {
           Console.WriteLine("Enemy defeated");
           IsDead = true; 
       }

        public virtual void Skill(Novice player)
        {
            player.GetHit(2 * AttackPower);
        }

        public virtual void BossSkill(Novice player)
        {
            player.GetHit(3 * AttackPower);
        } 

    }
    
}
