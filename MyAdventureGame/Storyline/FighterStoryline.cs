using System;

namespace MyAdventureGame
{
    class FighterStoryline
    {
        public FighterStoryline()
        {
            Fighter player = new Fighter();
            Battler battler = new Battler();
            Goar goar = new Goar();
            DoomTheConqueror doomTheConqueror = new DoomTheConqueror();
            Console.WriteLine("Well done, ");
            Console.WriteLine("You choose Fighter's Gloves to fullfil your power");
            Console.WriteLine("The spirits of the Fgihters will help you finish your journey");
            Console.Read();
            TreasureBox treasureBox = new TreasureBox();
            treasureBox.treasureBox();
            if(treasureBox.True)
            {
                player.Health = player.Health + 100;
                player.AttackPower = player.AttackPower + 10;
                player.Experience = player.Experience + 10; 
            }
            Console.WriteLine("You deserve the rewards, adventure! Now continue your journey!");
            Console.Read();
            Console.WriteLine("Go to the Phantom Cave. ");
            Console.WriteLine("Careful, you meet Battler, The winged servants of evil with damaging sonic scream.");
            Console.WriteLine(battler.Name+" is blocking you!");
            Encounter encounter2 = new Encounter(player, battler);
            Console.WriteLine("Congratulations, you defeated the enemy.");
            Console.WriteLine("Continue your journey, adventurer!");
            Console.WriteLine("");
            Console.Read();
            TreasureBox2 treasureBox2 = new TreasureBox2();
            treasureBox2.treasureBox2();
            if(treasureBox2.True)
            {
                 player.Health = player.Health + 200;
                 player.AttackPower = player.AttackPower + 20;
                 player.Experience = player.Experience + 10; 
            }
            
            Console.Read();
            if(battler.IsDead)
            {
            Console.WriteLine("Go to the Forsaken Forrest.");
            Console.Read();
            Console.WriteLine("Huge powerful jaws, terrible breath, and unstoppable power. This monster is like a bad hair day brought to life.");
            Console.WriteLine("The most strongest creatures you have ever seen. They are the guardian of this forrest. Watchout!!!");
            Console.WriteLine(goar.Name+" is blocking you!");
            Encounter encounter3 = new Encounter(player, goar);
            Console.WriteLine("Congratulations, you defeated the enemy.");
            Console.WriteLine("Continue your journey, adventurer!");
            Console.WriteLine("");
            Console.Read();
            }
            TreasureBox3 treasureBox3 = new TreasureBox3();
            treasureBox3.treasureBox3();
            if(treasureBox3.True)
            {
                 player.Health = player.Health + 300;
                 player.AttackPower = player.AttackPower + 25;
                 player.Experience = player.Experience + 10; 
            }
            Console.WriteLine("You deserve the rewards, adventure! Now continue your journey!");
            Console.Read();
            if(goar.IsDead)
            {
            Console.WriteLine("--DIALOGUE--");
            Console.WriteLine("");
            Console.WriteLine("                                                                         P = Player");
            Console.WriteLine("                                                                         D = Doom The Conqueror");
            Console.WriteLine("                                                                        GL = General Lightborn");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : I think this is the last place.");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Is this the Hall of Doom?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : I should walk around to figure something");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Is that!?!");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Yes! It's the Pandora Box");
            Console.WriteLine("P : But it's sealed");
            Console.WriteLine("P : How can i bring it to the Moniyan Empire?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("!!!");
            Console.WriteLine("D : HOW DARE YOU COME HERE, LITTLE WEAK HUMAN! WHAT ARE YOU DOING IN MY KINGDOM?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("D : ARE TOU TRYING TO STEAL SOME OF MY STUFF?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Your kingdom? Your Stuff? This box belongs to Moniyan Empire. You just stole it, weird monsters.");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("D : WHAT DID YOU SAY? DO YOU KNOW REALLY NOW ME?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Hmmm..., big ugly monsters?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("D : ARE YOU CHALLENGING ME, HUMAN?");
            Console.WriteLine("D : THE MIGHTIEST KING, YOUR FOREVER NIGHTMARE, THE END OF YOUR LIFE");
            Console.WriteLine("D : DOOM THE CONQUEROR");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Well, can i get this Pandora box?");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("D : HUMANNNNN!!!!");
            Console.WriteLine("-Doom transform into his true form");
            Console.WriteLine(doomTheConqueror.Name+" is attacking you");
            Encounter bossEncounter = new Encounter(player, doomTheConqueror);
            Console.WriteLine("You defeated final boss, Doom The Conqueror");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("--DIALOGUE--");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : Sheesh, he's really strong, but i'm the strongest.");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("P : I think i should bring this Pandora Box to Moniyan Empire immediately");
            Console.WriteLine("- you break the seal with Doom's sword ");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("-you arrived at Moniyan Empire");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("GL : Thank you for bringing back the Pandora Box ");
            Console.WriteLine("GL : Now Land of Dawn will be very peaceful");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("GL : You must be tired right? Come inside to the Moniyan Empire, we celebrate your and our victory");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("GL : A gift from me, you are promote to the Lightborn Squad");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("For now, the Land of Dawn live in peace and happinest");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Thank you for playing. See you again...");
            Console.ReadLine();
            Environment.Exit(0);
            }
            
            
        }
    }
   
}