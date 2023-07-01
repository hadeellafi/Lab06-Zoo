using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }

        public Bird(string name, int age, string featherColor, bool canFly) : base(name, age)
        {
            FeatherColor = featherColor;
            CanFly = canFly;
        }

        public virtual string Eat()
        {
            return "The bird is eating.";
        }
    }
    public class Eagle : Bird
    {
        public Eagle(string name, int age, string featherColor, bool canFly) : base(name, age, featherColor, canFly)
        {
        }

        public override string Eat()
        {
            return "The eagle is eating fish.";
        }
    }
    public class Parrot : Bird
    {
        public Parrot(string name, int age, string featherColor, bool canFly) : base(name, age, featherColor, canFly)
        {
        }

        public override string Eat()
        {
            return "The parrot is eating seeds and fruits.";
        }
    }


}
