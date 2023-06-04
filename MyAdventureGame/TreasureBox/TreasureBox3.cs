using System;
using System.Collections.Generic;

namespace MyAdventureGame
{

    class TreasureBox3
    {
        public bool True { get; set; }
        public void treasureBox3()
        {
        Novice player = new Novice();
        string number = "2746";
        int chance = 3;
        List<string> playerGuess = new List<string>{};

        Console.WriteLine("The spirits give you a reward for your battle, a Treasure Box");
        Console.WriteLine("");
        Console.WriteLine("But, you must try to guess a number combination and unlock the box to claim the rewards");
        Console.WriteLine("");
        Console.WriteLine("You have "+chance+" chance to guess the combination");
        Console.WriteLine($"The combination are in {number.Length} numbers");

        while(true){
            Console.WriteLine("");
            Console.WriteLine("Guess the combination!");
            string input = Console.ReadLine();
            
            playerGuess.Add(input);
            if(combinationCheck(number,playerGuess)){
                True = true;
                Console.WriteLine("");
                Console.WriteLine("Congratulation, you unlocked the box ["+number+"]");
                Console.WriteLine("You deserve the rewards, adventure! Now continue your journey!");
                break;
            }else if(number.Contains(input)){
                Console.WriteLine("");
                Console.WriteLine(numberCheck(number,playerGuess));
            }else{
                Console.WriteLine("");
                Console.WriteLine("Wrong number");
                chance = chance - 1;
                Console.WriteLine("Your chance remaining  : "+chance);
                Console.WriteLine("");
            }
            if(chance == 0){
                Console.WriteLine("");
                Console.WriteLine("The box is disappear. You can't get your rewards.");
                break;
            }
        }
        


            static string numberCheck(string kata_rahasia, List<string> playerGuess){
                string output = "";
                for(int i=0 ; i<kata_rahasia.Length ; i++){
                    string c = Convert.ToString(kata_rahasia[i]);
                    if(playerGuess.Contains(c)){
                        output = output + c;
                    }else{
                        output = output + "_";
                    }
                }
                return output;  
            }
            static bool combinationCheck(string kata_rahasia, List<string> playerGuess)
            {
                bool status = false;
                for(int i=0 ; i<kata_rahasia.Length ; i++){
                    string c = Convert.ToString(kata_rahasia[i]);
                    if(playerGuess.Contains(c)){
                        status = true;
                    }else{
                        return status = false;
                    }
                }
                return status;  

            }
        }
       
    }
            
}