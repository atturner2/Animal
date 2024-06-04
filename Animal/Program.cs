 class AnimalBaseClass  // Base class (parent) 
{
    public virtual void animalSoundVirtual()
    {
        Console.WriteLine("The animal makes a sound from the method in the base class");
    }


    public void walk()
    {
        Console.WriteLine("The animals all walk the same because they inherit the same method that is not overidden");
    }
}

class Pig : AnimalBaseClass  // Derived class (child) 
{
    public override void animalSoundVirtual()
    {
        Console.WriteLine("The pig says: wee wee from it's overidden method");
    }
}

class Dog : AnimalBaseClass  // Derived class (child) 
{
   

    
}

abstract class AnimalAbstractClass
{
    public abstract void animalSoundAbstract();


    public void walk()
    {
        Console.WriteLine("The animals all walk the same because they inherit the same method that is not overidden. In the abstract class this is allowed, but not in an interface.");
    }
}

class AbstractPig : AnimalAbstractClass  // Derived class (child) 
{
    public override void animalSoundAbstract()
    {
        Console.WriteLine("The pig says: wee wee from it's abstract method. This method must be defined because it's an abstract method in the base abstract class.");
    }
}

class AbstractDog : AnimalAbstractClass  // Derived class (child) 
{
    public override void animalSoundAbstract()
    {
        Console.WriteLine("The dog says: bow wow from it's overidden method. This method must be defined because it's an abstract method in the base abstract class.");
    }


}

interface IAnimal
{
    void animalSoundInterface(); //these are abstract public methods
    void animalWalkInterface();
}

class PigClassFromInterface : IAnimal
{
    public void animalSoundInterface()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The interface pig says: wee wee from it's sound method.");
    }

    public void animalWalkInterface()
    {
        Console.WriteLine("The interface pig walks from it's walk method, which is defined for each class inherited from the interface. It cannot have a common walk method shared among inherited classes.");
    }
}

class DogClassFromInterface : IAnimal
{
    public void animalSoundInterface()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The interface dog says: bow wow from it's sound method");
    }
    public void animalWalkInterface()
    {
        Console.WriteLine("The interface dog walks from it's walk method, which is defined for each class inherited from the interface. It cannot have a common walk method shared among inherited classes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //notice here we cannot instantiate in instance of Animal because it is an abstract class
        AnimalBaseClass myAnimal = new AnimalBaseClass();  // Create a Animal object
        AnimalBaseClass myBaseClassPig = new Pig();  // Create a Pig object
        AnimalBaseClass myBaseClassDog = new Dog();  // Create a Dog object

        myAnimal.animalSoundVirtual();
        myAnimal.animalSoundVirtual();
        myBaseClassPig.animalSoundVirtual();
        myBaseClassDog.animalSoundVirtual();
        myAnimal.walk();
        myBaseClassPig.walk();
        myBaseClassDog.walk();

        //The below line is not allowed becuase you can't instantiate an abstract class directly
        //AnimalAbstractClass myAbstractAnimal = new AnimalAbstractClass();
        AnimalAbstractClass myAbstractClassPig = new AbstractPig();  // Create a Pig object
        AnimalAbstractClass myAbstractClassDog = new AbstractDog();  // Create a Dog object

        //The below object is not allowed and cannot be called
        //myAnimal.animalSoundVirtual();
        myAbstractClassPig.animalSoundAbstract();
        myAbstractClassDog.animalSoundAbstract();
        //myAnimal.walk();
        myAbstractClassPig.walk();
        myAbstractClassDog.walk();

        IAnimal myInterfacePig = new PigClassFromInterface();  // Create a Pig object
        IAnimal myInterfaceDog = new DogClassFromInterface();  // Create a Dog object

        //myAnimal.animalSoundVirtual();
        myInterfacePig.animalSoundInterface();
        myInterfaceDog.animalSoundInterface();
        //myAnimal.walk();
        myInterfacePig.animalWalkInterface();
        myInterfaceDog.animalWalkInterface();
    }
}
