using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part13_Non_OOP_vs_OOP_SolidPrinciple.WithOOP
{

    // here nasa isang file lang yung interface , abstract and class pero in web appliction mag kakaseperate file sya 

    //-----------------------
    //-- INTERFACE ---
    //-----------------------
    public interface IMandirigma //Interface 
    {
        //list lang yung members na pwede e-expose sa labas 
        string Name { get; }
        string Weapon { get; set; }

        void Attack();
    }

    //---------------------
    //-- ABSTRACT CLASS ---
    //---------------------
    public abstract class Mandirigma : IMandirigma //abstract class : and inherit the Interface of mandirigma so it forcing us to implement the members in the interface which is Name , Weapon , Attack  as we can see below implemented na sya sa code of block natin 
    {
        private string _secretWeapon; // here naka private yung secret weapon natin since scret nga sya so dapat di sya nakaexposed dapat naka encapsulated lang sya sa loob ng class  


        //Here sa constructor We have 2 property and yung values nya is pinapasa natin sa  Sa Name na property and _secretWeapon na variable 
        protected Mandirigma(string name, string secretWeapon) 
        {
            Name = name;
            _secretWeapon = secretWeapon;
        }
        //Implementing the members of Interface to fullfill the contract 
        public string Name { get; private set; }
        public string Weapon { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}: Attacks using {Weapon} & {_secretWeapon}");
        }
    }

    //---------------------
    //--  CLASS ---
    //---------------------

    // then inherit yung Mandirigma both Ninja and Samurai so that all member so Mandirigma will be acessible 

    // -- NINJA --
    public class Ninja : Mandirigma
    {
        // here sa Ninja we have 1 parameter lang para sa secret weapon natin and naka constructor chaining tayo sa : base na may 2 parameter na dito natin pinoprovide yung  Name = "Ninja" ,and  yung nakuha natin na value sa secret na sa Ninja Constructor natin yung  nasa unahan Ninja(string secret)  
        // and after natin makuha yung value here pinapasa nanatin to dun sa base na Mandirigma sa taas LINE 29 
        public Ninja(string secret) : base("Ninja", secret)
        {
        }

        // public override void Attack()
        // {
        //     Console.WriteLine($"{Name}: Strikes with {Weapon} & a hidden {_secretWeapon}");
        // }

        /*
            Sample of Constructor Chaining :
                Sample withing class only :
                    public Sample () : this("test"){
                    }
            >> and yung nasa taas is base na yung gamit kasi Class na yung gamit natin:  public abstract class Mandirigma and pag honover natin yung base we can see na yung class na mandirigma sya nag ma map 
            >> same lang yung ginagawa natin dun sa baba dun sa Samurai pero nag ooverride lang tayo dun nong method 
        */
    }

    //-- SAMURAI --
    public class Samurai : Mandirigma
    {
        
        public Samurai(string secret): base("Samurai", secret)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}: Wields {Weapon} ");
            Console.WriteLine($"OOP APROACH GO GO GO! RUFFA");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMandirigma ninja = new Ninja("Shuriken")
            {
                Weapon = "Katana"
            };
            ninja.Attack();

            IMandirigma samurai = new Samurai("Wakizashi")
            {
                Weapon = "Katana"
            };
            samurai.Attack();
        }
    }
}
