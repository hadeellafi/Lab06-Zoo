using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Reptile : Animal
    {
        public bool HasScales { get; set; }

        public Reptile(string name, int age, bool hasScales) : base(name, age)
        {
            HasScales = hasScales;
           
        }

        public virtual string Snap()
        {
            return "The reptile is Snap.";
        }
    }
    public class Crocodile : Reptile
    {
        public string JawSize { get; set; }

        public Crocodile(string name, int age, bool hasScales, bool isColdBlooded, string jawSize) : base(name, age, hasScales)
        {
            JawSize = jawSize;
        }

        public override string Snap()
        {
            return "The crocodile snaps its jaws.";
        }
    }

}
