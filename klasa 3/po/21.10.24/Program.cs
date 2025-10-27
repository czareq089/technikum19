using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcja
{
	internal class Program
	{
		public interface IAnimal
		{
			void MakeSound();
			void Eat();
		}
		public abstract class Animal : IAnimal
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public Animal(string imie, int wiek) 
			{
				Name = imie;
				Age = wiek;
			}
			public abstract void MakeSound();
			public void Eat()
			{
                Console.WriteLine($"{Name} je");
            }

		}
		public class Dog : Animal
		{
			public Dog(string imie, int wiek) : base(imie, wiek) { }
			public override void MakeSound()
			{
                Console.WriteLine("Hau, Hau, Hau");
            }
			public void Eat()
			{

			}
		}
		public class Cat : Animal
		{
			public Cat(string imie, int wiek) : base(imie, wiek) { }
			public override void MakeSound()
			{
                Console.WriteLine("Miau, Miau, Miau");
            }
			public void Eat()
			{

			}
		}

		static void Main(string[] args)
		{
            Dog dog = new Dog("Azor", 2);
			Cat cat = new Cat("Filemon", 3);
            dog.MakeSound();
			dog.Eat();
			cat.MakeSound();
			cat.Eat();

        }
	}
}