using System;

public abstract class Animal
{
    public string Name { get; set; }
    public abstract void Eat();
    public abstract void Sleep();
}

public abstract class Mammal : Animal
{
    public abstract void GiveBirth();
}

public abstract class Reptile : Animal
{
    public abstract void LayEggs();
}

public class Dog : Mammal
{
    public override void Eat()
    {
        Console.WriteLine("The dog is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The dog is sleeping.");
    }

    public override void GiveBirth()
    {
        Console.WriteLine("The dog gave birth.");
    }
}

public class Cat : Mammal
{
    public override void Eat()
    {
        Console.WriteLine("The cat is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The cat is sleeping.");
    }

    public override void GiveBirth()
    {
        Console.WriteLine("The cat gave birth.");
    }
}

public class Snake : Reptile
{
    public override void Eat()
    {
        Console.WriteLine("The snake is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The snake is sleeping.");
    }

    public override void LayEggs()
    {
        Console.WriteLine("The snake laid eggs.");
    }
}

public class Lizard : Reptile
{
    public override void Eat()
    {
        Console.WriteLine("The lizard is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The lizard is sleeping.");
    }

    public override void LayEggs()
    {
        Console.WriteLine("The lizard laid eggs.");
    }
}

public class Bird : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The bird is eating.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The bird is sleeping.");
    }

    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.Name = "Dog";
        dog.Eat();
        dog.Sleep();
        ((Mammal)dog).GiveBirth();

        Console.WriteLine();

        Animal cat = new Cat();
        cat.Name = "Cat";
        cat.Eat();
        cat.Sleep();
        ((Mammal)cat).GiveBirth();

        Console.WriteLine();

        Animal snake = new Snake();
        snake.Name = "Snake";
        snake.Eat();
        snake.Sleep();
        ((Reptile)snake).LayEggs();

        Console.WriteLine();

        Animal lizard = new Lizard();
        lizard.Name = "Lizard";
        lizard.Eat();
        lizard.Sleep();
        ((Reptile)lizard).LayEggs();

        Console.WriteLine();

        Animal bird = new Bird();
        bird.Name = "Bird";
        bird.Eat();
        bird.Sleep();
        ((Bird)bird).Fly();
    }
}
