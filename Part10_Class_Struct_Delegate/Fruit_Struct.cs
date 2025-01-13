using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part10_Class_Struct_Delegate
{
    public struct Fruit_Struct
    {
        public object Name { get; internal set; }

        /* 
            >> rigth click and click struct 
            >> struct is kung ano yung ginagawa natin before sa Custom Class is same lang dito 
            >> ang pinag kaiba lang ng struck is value type sya where sa Class is Reference Type sya 
            >> so instead of public class we use public struct 
            >> isa pa yung pinag kaiba nila is si struct sa constructor nya di sya pwede na empty where in sa class sa constructor nya is pwede kahit empty yung loob 
            >> isa pa yung bawal sa struct is directly mag seset ng value sa get set 
                     public string  Name { get; set; } = "Yow" :so  bawal to 
            >> pero in the class pwede sya 


        */



        public struct Fruits 
        {

            //so here as we can see yung na added na yung constructor with parameter 
            public Fruits (string name, string color)
            {
                Name = name;
                Color = color; 
            }

            public string  Name { get; set; }

            public string Color  { get; set; }  



        }


    }
}