using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotvsDinosaurTAKE2
{
    internal class Battlefield
    {
        //HAS A
        public Dinosaur Dino;
        public Robot Robotbot;

        public Battlefield()
        {
            Dino = new Dinosaur("Fluffy");
            Robotbot = new Robot("Botbot");
        }
        public void RunGame()
        {
            DisplayWelcome();
            Fight();
            DisplayWinner();
        }
        public void DisplayWelcome()

        {
            Console.WriteLine($"Welcome to the battle of {Robotbot.Name} the Robot vs {Dino.Name} the Dinosaur!");
        }
        public void Fight()
        {
            while (Dino.Health > 0 && Robotbot.Health > 0)
            {
                Dino.AttackRobot(Robotbot);
                Robotbot.AttackDinosaur(Dino);
            }
        }
            public void DisplayWinner()
            {
                if (Dino.Health <= 0)
                {
                    Console.WriteLine($"{Robotbot.Name} is the winner!");
                }
                else
                {
                    Console.WriteLine($"{Dino.Name} is the winner!");
                }
            }

        }
    }





