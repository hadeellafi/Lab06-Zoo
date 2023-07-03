using Zoo;
using Zoo.Interfaces;

namespace TestZoo
{
    public class UnitTest1
    {
        /// <summary>
        /// /////////////lab 06 tests
        /// </summary>
        [Fact]
        public void DogShouldEat()
        {
            var dog = new Dog("Max", 5, "Brown", "Labrador");

            var result = dog.Eat();

            Assert.Equal("dog is eating", result);
        }

        [Fact]
        public void EagleShouldBeAbleToFly()
        {
            var eagle = new Eagle("Aquila", 5, "Brown", true);

            var result = eagle.CanFly;

            Assert.True(result);
        }
        [Fact]
        public void ParrotShouldMakeSound()
        {
            var parrot = new Parrot("Polly", 2, "Green", true);

            var result = parrot.Eat();

            Assert.Equal("The parrot is eating seeds and fruits.", result);
        }

        [Fact]
        public void CrocodileShouldSnap()
        {
            var crocodile = new Crocodile("Croc", 10, true, "Large");

            var result = crocodile.Snap();

            Assert.Equal("The crocodile snaps its jaws.", result);
        }
        //////////////////////lab07 tests/////////////////////////////////////
        
        ///Test that the classes that implement the interface actually implement it
        [Fact]
        public void DogImplementsIAttack()
        {
            Dog dog = new Dog("Max", 5, "Brown", "Labrador");

            Assert.NotNull((IAttack)dog);
        }
        [Fact]
        public void CrocodileImplementsIAttack()
        {
            var crocodile = new Crocodile("Croc", 10, true, "Large");

            Assert.NotNull((IAttack)crocodile);
        }
        [Fact]
        public void DogImplementsISpeed()
        {
            Dog dog = new Dog("Max", 5, "Brown", "Labrador");

            Assert.NotNull((ISpeed)dog);
        }
        //////Test inheritance//////////
        [Fact]
        public void DogInheritsFromMammal()
        {
           
            Dog dog = new Dog("Max", 3, "Black", "Labrador");
            Assert.IsAssignableFrom<Mammal>(dog);
        }

        [Fact]
        public void EagleInheritsFromBird()
        {
            Eagle eagle = new Eagle("Sam", 10, "Brown", true);
            Assert.IsAssignableFrom<Bird>(eagle);
        }

        [Fact]
        public void CrocodileInheritsFromReptile()
        {
            Crocodile crocodile = new Crocodile("Rocky", 15, true, "Large");

            Assert.IsAssignableFrom<Reptile>(crocodile);
        }

        ///Test Polymorphism 
        //Prove methods have been overridden

        [Fact]
        public void DogMakeSound_Override_Success()
        {
            var dog = new Dog("Max", 5, "Brown", "Labrador");

            string sound = dog.Sound();

            Assert.Equal("Woof!", sound);
        }


        [Fact]
        public void CatMakeSound_Override_Success()
        {
            var cat = new Cat("Whiskers", 3, "Gray", "Blue");
            var result = cat.Sound();
            Assert.Equal("Meow!", result);
        }
        /// Prove that one of your concrete animals is an Animal
        [Fact]
        public void TestDogIsAnimal()
        {
            Dog dog = new Dog("max", 3, "black", "Labrador");

            Assert.IsAssignableFrom<Animal>(dog);
        }
    }
}