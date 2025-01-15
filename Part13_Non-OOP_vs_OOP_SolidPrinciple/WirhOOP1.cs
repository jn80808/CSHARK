using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Part13_Non_OOP_vs_OOP_SolidPrinciple.WithoutOOP1;

namespace Part13_Non_OOP_vs_OOP_SolidPrinciple
{
    public class WirhOOP1
    {
            public void Process()
                {
                    Print(new Ninja { Weapon = "Fireball", SecretWeapon = "Shuriken" });
                    Print(new Samurai { Weapon = "Sword", SecretWeapon = "3 swords style" });
                }

            public void Print(Ninja ninja)
                {
                    ninja.SecretWeapon = "Gun"; // Modify SecretWeapon
                    ninja.Attack(); // Call Attack method
                }

            public void Print(Samurai samurai)
                {
                    samurai.SecretWeapon = "Knife"; // Modify SecretWeapon
                    samurai.Attack(); // Call Attack method
                }
    }
    
}