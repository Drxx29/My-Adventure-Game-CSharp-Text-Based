using System;

namespace MyAdventureGame
{
    class Lithowanderer : Enemy
    {
        //Little but Deadly, silence but scary. Don't make this little creature be your nightmare.
        public Lithowanderer()
        {
            Health = 50;
            AttackPower = 9;
            Name = "Lithowanderer";
            Console.WriteLine("You pass the Red Grass Field");
            Console.Read();
            Console.WriteLine("You meet "+Name+". Little but Deadly, silence but scary. Don't make this little creature be your nightmare.");
            Console.WriteLine(Name+" is blocking you!");
        }

        public override void Skill(Novice player)
        {
            Console.WriteLine("Claws!");
            base.Skill(player);
        }
    }
}