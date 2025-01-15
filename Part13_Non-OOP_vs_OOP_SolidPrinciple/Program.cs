using Part13_Non_OOP_vs_OOP_SolidPrinciple.WithOOP;
using static Part13_Non_OOP_vs_OOP_SolidPrinciple.WirhOOP;
using static Part13_Non_OOP_vs_OOP_SolidPrinciple.WithoutOOP;

namespace Part13_Non_OOP_vs_OOP_SolidPrinciple
{
    class OOP_vs_OOP_SolidPrinciple
    {
        //we have 2 class : Ninja and Samurai that have same set up members ang pinagkaiba lang is yung default propert name 
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja
            {
                Weapon = "Shuriken",
                SecretWeapon = "Smoke Bomb"
            };
            ninja.Attack();

            Samurai samurai = new Samurai
            {
                Weapon = "Katana",
                SecretWeapon = "Hidden Blade"
            };
            samurai.Attack();


        }
    }
}


