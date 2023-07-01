using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
     abstract public class Mammal:Animal
    {
        public string FurColor { get; set; }
        public Mammal(string name,int age,string fur):base(name,age) {
            FurColor = fur;
        }
        abstract public string Eat();

        public virtual string Sound()
        {
            return "Mammal sound";
        }

    }
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string furColor, string breed) : base(name, age, furColor)
        {
            Breed = breed;
        }
        public override string Eat()
        {
            return "dog is eating";
        }
        public override string Sound()
        {
            return "Woof!";
        }
        

    }
    public class Cat : Mammal
    {
        public string EyeColor { get; set; }

        public Cat(string name, int age, string furColor, string eye) : base(name, age, furColor)
        {
            EyeColor = eye;
        }

        public override string Sound()
        {
            return "Meow!";
        }
        public override string Eat()
        {
            return "cat is eating";
        }
    }

}
