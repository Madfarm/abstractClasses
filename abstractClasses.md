# Abstract Classes
classes that cannot be instantiated and can only be accessed by inheriting the class

blueprint for polymorphism basically

- abstract methods => empty emethods that must be implemented in the inherited class


denote abstract classes and methods with the "abstract" keyword

public abstract class Animal
{
    public abstract string animalSound();
}

then inherit the class with :

public class Dog : Animal
{
    public string animalSound()
    {
        return "bark!";
    }
}


when we want to use values from the abstract classes constructor we use the : also

public FreeUser(string name) : base(name)
{
    this.AccountType = "free";
}

the base keyword tells this constructor to call the base class constructor that with paramenter name