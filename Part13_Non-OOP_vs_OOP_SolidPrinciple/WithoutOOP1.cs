using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part13_Non_OOP_vs_OOP_SolidPrinciple
{
    public class WithoutOOP1
    {
            #region Demo Class

                public class Ninja
                {
                    public string Name { get; } = "Ninja";
                    public string SecretWeapon { get; set; }
                    public string Weapon { get; set; }

                    public void Attack()
                    {
                        Console.WriteLine($"{Name}: Attacks using {Weapon} & {SecretWeapon}");
                    }
                }

                public class Samurai
                {
                    public string Name { get; } = "Samurai";
                    public string SecretWeapon { get; set; }
                    public string Weapon { get; set; }

                    public void Attack()
                    {
                        Console.WriteLine($"{Name}: Attacks using {Weapon} & {SecretWeapon}");
                    }
                }

            #endregion





    }
}