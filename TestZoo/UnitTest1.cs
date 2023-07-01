using Zoo;
namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void DogShouldEat()
        {
            var dog = new Dog("Max", 5, "Brown", "Labrador");

            var result = dog.Eat();

            Assert.Equal("dog is eating", result);
        }

        [Fact]
        public void CatShouldMakeSound()
        {
            var cat = new Cat("Whiskers", 3, "Gray", "Blue");
            var result = cat.Sound();
            Assert.Equal("Meow!", result);
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
            var crocodile = new Crocodile("Croc", 10, true, true, "Large");

            var result = crocodile.Snap();

            Assert.Equal("The crocodile snaps its jaws.", result);
        }
    }
}