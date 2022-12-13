using System;

namespace Poly
{
    public abstract class Laptop
    {
        public abstract string Type { get; }
        public string Name { get; set; }

        public abstract void TurnOn();
        public abstract void TurnOn(bool boot);
    }
}