using System;
namespace RobotVsDinosaurUpdated
{
    public class Battlefield
    {
        public Robot Tron;
        public Dinosaur TFlex;

        public Battlefield()
        {
            this.Tron = new Robot("Tron", 250);
            TFlex = new Dinosaur("TFlex", 250, 20);
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Robot vs Dinosaur!");

        }

        public void Battle()
        {
            bool isRobotattacker = true;
            while (this.Tron.Health > 0 && this.TFlex.Health > 0)
            {

                if (isRobotattacker)
                {
                    this.TFlex.RecieveDamage(this.Tron.ActiveWeapon.AttackPower);
                    Console.WriteLine($"{TFlex.Name} is attacked by {Tron.Name}\nTheir health is now {TFlex.Health}");

                }
                else
                {
                    this.Tron.ReceiveDamage(this.TFlex.AttackPower);
                    Console.WriteLine($"{Tron.Name} is attacked by {TFlex.Name}\nTheir health is now {Tron.Health}");

                }
                isRobotattacker = !isRobotattacker;
            }
        }

        public void DisplayWinner()
        {
            if (this.Tron.Health > 0)
            {
                Console.WriteLine(" Tron wins!");
            }
            else
            { Console.WriteLine("TFlex wins!"); }
        }

        public void RunGame()
        {
            DisplayWelcome();
            Battle();
            DisplayWinner();
        }
    }
}

