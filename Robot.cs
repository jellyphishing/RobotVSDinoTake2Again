using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RobotvsDinosaurTAKE2
{
    public class Robot
    {  //HAS A
    public string Name;
    public int Health;
    public Weapon ActiveWeapon;

    //Constructor
    public Robot(string name)
    {
        Name = name;
        Health = 100;
        ActiveWeapon = new Weapon();

    }
    //CAN DO

    public void AttackDinosaur(Dinosaur dino)
    {
        dino.Health -=ActiveWeapon.AttackPower;
        Console.WriteLine($"Robot {Name} attacked the dinosaur {dino.Name} for {ActiveWeapon.AttackPower} damage. {dino.Name} now has {dino.Health} health left.");
    }
}
    
}
