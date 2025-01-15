using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part13_Non_OOP_vs_OOP_SolidPrinciple.WithOOP
{
    public class SampleOperationWithOOP
    {
        
    public class SimpleOperationWithOOP
    {
        /*
            >> here we have 2 method the Process & Print 
            >> and the Print method meron syang parameter na IMandirigma which IMandirigma : Data type , madirigma : parametername 
            >> IMandirigma is yang yung abstract Interface class natin which mean pwede tayo makaaccess ng class nanakainhirit sa  IMandirigma 
            >> Since si Ninja and Samurai Class in naka inherit sa Mandirigma ibigsabhihin Parent nila si Mandirigma 
            >> Child : Parent 
            >> Ninja : Mandirigma 
            >> and si Mandirigma is naka Inherit sa IMandirigma 
            >> Mandirigma : IMandirigma 
            >> means pareny ni Mandirigma si IMandirigma 
            >> kaya Pwede sila Parameter value ni Print Menthod 

            NINJA   \
                        MANDIRIGMA -> IMANDIRIGMA 
            SAMURAI /

            >> Kaya IMANDIRIGMA kasi acceptable sila 
            >> kaya here sa Process Method dun sa loob ng code block natin is tinatawag lang natin ng dalawang beses yung Print Method 
            >> Print para sa Ninja and yung isa para sa Samurai 
            >> yung sa loob naman nong Print Method yung ginamit nanatin yung attack dun sa IMandirigma is eexecute nya lang yung implementation mo sa class na nag inhirit nito di na nya need malaman pano mo to inimplement dun sa code basta  tatawagin nya lang yung method 
            >> yung implementation natin sa attack sa Ninja sa Samurai is mag kaiba 
            >> sa line 81 as we can si we samurai is nag ooveride dun may iba pa sya ginagawa ang tawag dun is multiple forms  kaya si samurai is pasok sya polymorphism 
            >> and here sa Print method natin kahit may 1k record to print basta naka inherit sa mandirigma is pwede dito kasi irereuse nya lang yung code  kaya isang Print Method lang yung need natin kahit ilan pa yung model mo 
            >> Unlike sa withoutOOP Need mo idefine yung function for every model and if may need ka change kang kaylangan sa model mo like change sa functionality lahat yun need mo baguhin or I-uupdate mo 
            >> Unlike sa OOP pag yung abstract lang yung ichachange abstract lang yung babaguhin mo 1 change then apply to all na sya so OOP Its like a puzzle per piece and pinag kakabit kabit sya 
            >> We justly need to take advantage of the Abstraction , Inheritance , Encapsulation , Polymorphism 
            >> Just follows the best tractice 

        */
        public void Process()
        {
            Print(new Ninja("Shuriken") { Weapon = "Fireball" });
            Print(new Samurai("3 swords style") { Weapon = "Sword" });
        }

        public void Print(IMandirigma mandirigma)
        {
            mandirigma.Attack();
        }
    }







    }
}