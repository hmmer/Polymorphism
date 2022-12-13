using System;

namespace Poly
{
    public class Lenovo : Laptop
    {
    
        public override string Type => "Run Time / Dynamic Polymorphism";

        public Lenovo()
        {
            base.Name = "Lenovo";
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