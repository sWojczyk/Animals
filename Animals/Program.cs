using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Reksio", Animal.EnumSex.Male, "Kundelek");
            Animal a = d;
            Mammal m = d;
            ISound so = d;
            ISwimmable sw = d;

            Console.WriteLine(d.Name);
            Console.WriteLine(d.Sex);
            Console.WriteLine(d.Breed);
            Console.WriteLine(d.GetVoice());
            Console.WriteLine(d.Swim());

            Console.WriteLine("----------------------------");

            Console.WriteLine(a.Name);
            Console.WriteLine(a.Sex);
            if (a is Dog) { Console.WriteLine((a as Dog).Breed); }
            if (a is ISound) { Console.WriteLine((a as ISound).GetVoice()); }
            if (a is ISwimmable) { Console.WriteLine((a as ISwimmable).Swim()); }

            Console.WriteLine("----------------------------");

            Console.WriteLine(m.Name);
            Console.WriteLine(m.Sex);
            if (m is Dog) { Console.WriteLine((m as Dog).Breed); }
            Console.WriteLine(m.GetVoice());
            if (m is ISwimmable) { Console.WriteLine((m as ISwimmable).Swim()); }


            Console.WriteLine("----------------------------");

            if (so is Animal) { Console.WriteLine((so as Animal).Name); }
            if (so is Animal) { Console.WriteLine((so as Animal).Sex); }
            if (so is Dog) { Console.WriteLine((so as Dog).Breed); }
            so.GetVoice();
            if (so is ISwimmable) { Console.WriteLine((so as ISwimmable).Swim()); }

            Console.WriteLine("----------------------------");

            if (sw is Animal) { Console.WriteLine((sw as Animal).Name); }
            if (sw is Animal) { Console.WriteLine((sw as Animal).Sex); }
            if (sw is Dog) { Console.WriteLine((sw as Dog).Breed); }
            if (sw is ISound) { (sw as ISound).GetVoice(); }
            sw.Swim();

            Cat c = new Cat("Mruczek", Animal.EnumSex.Male, "Pers");

            Console.WriteLine("----------------------------");

            List<Animal> animals = new List<Animal>();
            animals.Add(d);
            animals.Add(c);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Sex);

                if(animal is Dog)
                {
                    Console.WriteLine("To jest pies rasy " + (animal as Dog).Breed);
                }
                if (animal is ISound)
                {
                    Console.WriteLine("Wydaje dźwięk: " + (animal as ISound).GetVoice());
                }
                if (animal is ISwimmable)
                {
                    Console.WriteLine("Pływa: " + (animal as ISwimmable).Swim());
                }
            }

            Console.WriteLine("----------------------------");

            List<ISwimmable> swimmers = new List<ISwimmable>();
            swimmers.Add(d);
            swimmers.Add(c);

            foreach (ISwimmable swimmer in swimmers)
            {
                Console.WriteLine(swimmer.Swim());
            }

        }

    }
}
