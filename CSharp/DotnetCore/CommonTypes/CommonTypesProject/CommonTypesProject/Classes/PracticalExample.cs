using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Classes
{
    public abstract class Animal
    {
        public void Born() { }
        public abstract string MakeSound();

    }

    public abstract class Domestic : Animal
    {
        public void Run() { }

    }

    public abstract class Aquatic : Animal {
        public void Swim() { }
    }

    public sealed class Whalee : Aquatic
    {
        public override string MakeSound()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class Dog : Domestic

    {
        public override string MakeSound() { return "Guau"; }
    }

    public sealed class Cat : Domestic
    {
        public override string MakeSound() { return "Miau"; }
    }

    public sealed class AnimateAnimal
    {
        public void Move()
        {
            var whalee = new Whalee();
            whalee.Swim();
        }
    }
}
