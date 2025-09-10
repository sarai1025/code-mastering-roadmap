using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Classes
{
    public class Animal
    {
        public void Born() { }
        public void Breath() { }

    }

    public class Bird : Animal
    {
        public void Fly() { }
    }

    public class Fish : Animal {
        public void Swim() { }
    }

    public sealed class Whalee : Fish
    {
        
    }

    public sealed class Parrot : Bird

    {

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
