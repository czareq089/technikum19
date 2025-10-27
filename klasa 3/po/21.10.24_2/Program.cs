class Program
{
    public interface IAnimal
    {
        public void MakeSound();
        public void Eat();
    }

    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine($"{Name} je.");
        }
    }

    public class Dog : Animal
    {
        public Dog (string name, int age) : base(name, age) {}

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public void Eat()
        {
            
        }
    }
    
    public class Cat : Animal
    {
        public Cat (string name, int age) : base(name, age) {}
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Eat()
        {
            
        }
    }

    public static void Main()
    {

        var animals = new List<Animal>
        {
            dog, cat,
            new Dog("Azor", 3),
            new Cat("Mruczek", 2)
        };
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}