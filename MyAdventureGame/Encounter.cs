using System;

namespace MyAdventureGame
{
    class Encounter
    {
        public Encounter(Novice player, Enemy enemy)
        {
            Console.WriteLine("You encountering "+enemy.Name);
            Console.WriteLine(enemy.Name+" is attacking you");
            Console.WriteLine("Choose your action : ");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. SKill");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run away");
            if(Fighter.StunDuration <= 0)
            {
                enemy.IsStunned = false;
            }
            
            while(!enemy.IsDead && !player.IsDead && !player.IsRunningAway)
            {               
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                
                switch(playerAction)
                {
                    case "1" : 
                    Console.WriteLine("You doing a single attack...");
                    enemy.GetHit(player.AttackPower);
                    if(!enemy.IsStunned)
                    {
                        player.GetHit(enemy.AttackPower);
                    }
                    player.Experience+=0.3f;
                    Console.WriteLine("Player Health : "+player.Health+" | "+enemy.Name+" Health : "+enemy.Health);
                    break;
                    case "2" :
                    player.Skill(enemy);
                    
                    player.Experience+=0.9f;
                    Console.WriteLine("Player Health : "+player.Health+" | "+enemy.Name+" Health : "+enemy.Health);
                    break;
                    case "3" :
                    player.Defend();
                    if(!enemy.IsStunned)
                    {
                        if(rnd.Next(1,4)==2){
                        enemy.Skill(player);
                        }
                    }
                    player.Experience+=0.2f;
                    Console.WriteLine("Player Health : "+player.Health+" | "+enemy.Name+" Health : "+enemy.Health);
                    break;
                    case "4" :
                    player.IsRunningAway = true;
                    Console.WriteLine("You deciding to running away");
                    player.RunningAway();
                    player.Experience = 0;
                    Console.Read();
                    break;
                } 
                if(enemy.IsStunned){
                    Fighter.StunDuration--;
                }
            }
            if(enemy.IsDead){
                Console.WriteLine("You get "+player.Experience+" experience poin ");
                Console.WriteLine("Level up");
                player.Health+=100;
                player.AttackPower+=10;
                Console.WriteLine("Player Health : "+player.Health+" | "+enemy.Name+" Health : "+enemy.Health);
            }else if(player.IsDead){
                Console.WriteLine("Thank you for playing");
                Environment.Exit(0);
            }
        
        }
    }


}