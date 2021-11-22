using System;

namespace ANTI.KLAUS
{
    class Program
    {
        static void Main(string[] args)
        {
            Anti anti = new Anti();
            Klaus klaus = new Klaus();
            Console.Title = "ANTI.KLAUS, a christmas disaster?";
            Console.WriteLine("'Twas the night before christmas, a storm was brewing over the small town of Dunmel.");
            Console.WriteLine("Distraught a mother clutches her her baby closer to her bosom, only a few steps away from the right doorsteps");
            Console.WriteLine("But when the bell is pressed only the baby is left.");
            Console.ReadLine();
            anti.name = "Anti";
            Console.ReadLine();
            Console.WriteLine("You are " + anti.name);
            klaus.name = "Santa Claus";
            Console.WriteLine("You finally found him, it only took you ten years. The fat present man must die.");
            Console.WriteLine("What is your weapon of choice?");
            anti.weapon.weaponName = Console.ReadLine();
            klaus.weapon.weaponName = "Kindness";
            Console.WriteLine("While the other kids got presents, you got abandoned");
            Console.WriteLine("The world is cruel and unfair, other people should suffer like he did. Press 1 to fight Santa");
            Console.WriteLine("The world is cruel and unfair, but what happned to was never Santa fault. Press 2 to seek therapy");
            ConsoleKey key = ConsoleKey.A;
            while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {

                    while (anti.hhp > 0 && klaus.hhp > 0)
                    {
                        int h = anti.hhp;
                        h -= klaus.weapon.Damage();
                        klaus.SetHp(h);

                        int h2 = klaus.hhp;
                        h2 -= anti.weapon.Damage();
                        anti.SetHp(h);


                        klaus.hhp -= anti.weapon.Damage();
                        Console.WriteLine("You have " + anti.hhp + "HP, and " + klaus.name + "has " + klaus.hhp + " HP.");
                        if (klaus.hhp < 0)
                        {
                            Console.WriteLine(klaus.name + " is DEAD");
                        }
                        if (anti.hhp < 0)
                        {
                            Console.WriteLine(anti.name + " is DEAD");
                        }
                    }
                }
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.D2)
                {
                    while (anti.hhp > 0 && klaus.hhp > 0)
                    {
                        Console.WriteLine("In a freak accident you get shot on your way to your first appointment");
                        Console.WriteLine("There is no happy ending.");
                        Console.ReadLine();

                    }
                }

            }


            Console.ReadLine();
        }
    }
}
