using System;

namespace MyAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Opening opening = new Opening();


            Console.WriteLine("GL : Anyway, what is your name?");
            Console.Write("Your name : ");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi, "+player.Name+", are you ready to begin your journey?{y/n}");
            string aReady = Console.ReadLine();
            if(aReady == "y")
            {
                Lithowanderer lithowanderer = new Lithowanderer();
                Encounter encounter1 = new Encounter(player, lithowanderer);
                Console.WriteLine("Congratulation, "+player.Name+". You defeated the enemy.");
                Console.Read();
                Console.WriteLine("Spirits of the past want you to choose 1 of 4 Spirit's Equipment");
                Console.WriteLine("1. Fighter's Gloves");
                Console.WriteLine("2. Assassin's Blade");
                Console.WriteLine("3. Mage's Scroll");
                Console.WriteLine("4. Marksman's Gun ");
                Console.WriteLine("Choose well! : ");
                while(!player.IsDead && !player.IsRunningAway)
                {
                    string playerAction = Console.ReadLine();
                    Random rnd = new Random();
                
                    switch(playerAction)
                    {
                        case "1" : 
                        FighterStoryline fighterStoryline = new FighterStoryline();
                        break;
                        case "2" :
                        AssassinStoryline assassinStoryline = new AssassinStoryline();
                        break;
                        case "3" :
                        MageStoryline mageStoryline = new MageStoryline();
                        break;
                        case "4" :
                        MarksmanStoryline marksmanStoryline = new MarksmanStoryline();
                        break;
                    }
                }
                
                
            }else{
                Console.WriteLine("Well, comeback again when you're ready...");
                Console.Read(); 
                }
        }
    }
}
