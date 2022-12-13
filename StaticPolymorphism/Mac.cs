using System;

namespace Poly
{
    public class Mac : Laptop
    {
        public override string Type => "Compiler Time / Static Polymorphism";

        public override void TurnOn()
        {
            Console.WriteLine($"{Type}: no parameters");
            Console.WriteLine($"Turning On");
        }

        public override void TurnOn(bool boot)
        {
            Console.WriteLine($"{Type}: with parameters");
            
            if(boot)
            {
                Console.WriteLine($"Booting...");
            }
            else
            {
                Console.WriteLine($"No Boot");
            }
            
            Console.WriteLine($"Turning On");
        }
    }
}