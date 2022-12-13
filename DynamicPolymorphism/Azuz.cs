using System;

namespace Poly
{
    public class Azuz : Laptop
    {
    
        public override string Type => "Run Time / Dynamic Polymorphism";

        public Azuz()
        {
            base.Name = "Azuz";
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Type}");
            Console.WriteLine($"Turning On {Name}");
        }

        public override void TurnOn(bool boot)
        {
            Console.WriteLine($"{Type}");
            
            if(boot)
            {
                Console.WriteLine($"Booting...");
            }
            else
            {
                Console.WriteLine($"No Boot");
            }
            
            Console.WriteLine($"Turning On {Name}");
        }
    }
}