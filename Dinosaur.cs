using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotvsDinosaurTAKE2
{
    public class  Dinosaur
    {  //Has A
       public  string Name;
        public int Health;
        public int AttackPower;

        //Constructor
        public Dinosaur(string name)
        {

            Name = name;
            Health = 100;
            AttackPower = 20;


        }

        //CAN DO
        public void AttackRobot(Robot robot)
        {
            robot.Health -= AttackPower;
            Console.WriteLine($"Dinosaur {Name} attacked the Robot {robot.Name} for {AttackPower} damage. {robot.Name} now has {robot.Health} left.");

        }



    }
}
