// Define an interface
public interface IAnimal
{
    void MakeSound();
}

// Implement the interface in a class
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}


public static void Main()
{
    IAnimal dog = new Dog();
    dog.MakeSound();  // Output: Woof!

    IAnimal cat = new Cat();
    cat.MakeSound();  // Output: Meow!
}
