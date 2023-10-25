using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract public class Animal
    {
        public enum EnumSex { Male, Female }

        private string name;
        private EnumSex sex;

        public string Name { get => name; set => name=value; }
        public EnumSex Sex { get => sex; set => sex=value; }

        protected Animal(string name, EnumSex sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
    abstract class Mammal : Animal, ISound
    {
        protected Mammal(string name, EnumSex sex) : base(name, sex)
        {
        }

        public abstract string GetVoice();
    }
    class Dog : Mammal, ISwimmable
    {
        private string breed;
        public string Breed { get => breed; set => breed=value; }
        public Dog(string name, EnumSex sex, string breed) : base(name, sex)
        {
            this.breed=breed;
        }
        public override string GetVoice()
        {
            return "wooh";
        }
        public string Swim()
        {
            return "I like swimming";
        }
    }
    class Cat : Mammal, ISwimmable
    {
        private string breed;
        public string Breed { get => breed; set => breed=value; }
        public Cat(string name, EnumSex sex, string breed) : base(name, sex)
        {
            this.breed=breed;
        }
        public override string GetVoice()
        {
            return "meow";
        }
        public string Swim()
        {
            return "I can";
        }
    }
}
