using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Zoo;

namespace TestZoo
{
    public class UnitTest1
    {
        Lion lion = new Lion("Roar");
        Eagle eagle = new Eagle(true , "Scream" ,"Meat", "Yellow");
        Cow cow = new Cow("Moo", "Grass");
        Crocodile crocodile = new Crocodile("Growls", "Meat");
        Penguin penguin = new Penguin(false , "Bleat", "Fish", "Orange");

        [Fact]
        public void FirstLion()
        {
            Assert.Equal($"I go {lion.sound}", lion.Sound());
        }

        [Fact]
        public void SecondLion()
        {
            Assert.Equal("I can jump more than 2 metters", lion.CanJump());
        }

        [Fact]
        public void FirstEagle()
        {
            Assert.True(eagle.Fly(eagle.canFly));
        }

        [Fact]
        public void SecondEagle()
        {
            Assert.Equal($"My beak color is {eagle.beakColor}", eagle.BeakColor());
        }

        [Fact]
        public void FirstCow()
        {
            Assert.Equal("I do NOT hibernate during winter", cow.Hibernate());
        }

        [Fact]
        public void SecondCow()
        {
            Assert.Equal($"I go {cow.sound}", cow.Sound());
        }

        [Fact]
        public void FirstCrocodile()
        {
            Assert.Equal("I can swim and I live in the water", crocodile.CanSwim());
        }

        [Fact]
        public void SecondCrocodile()
        {
            Assert.Equal($"{crocodile.sound}", crocodile.Sound());
        }

        [Fact]
        public void FirstPenguin()
        {
            Assert.Equal($"My beak color is {penguin.beakColor}", penguin.BeakColor());
        }

        [Fact]
        public void SecondPenguin()
        {           
            Assert.True(!penguin.Fly(penguin.canFly));
        }

        [Fact]
        public void OverrideMethod()
        {
            Assert.NotEqual("I go roarrrrrr", lion.Sound());
        }
        
        [Fact]
        public void IsAnimal()
        {            
            Assert.True(lion is Animal);
        }

        [Fact]
        public void ImplementTheInterface()
        {
            Assert.Equal("I am a cat but i can swim", lion.CanSwim());
        }

        [Fact]
        public void ImplementTheInterfaceTwo()
        {
            Assert.Equal("I can jump more than 2 metters", lion.CanJump());
        }
    }
}
