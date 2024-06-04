# Animal
Simple example of polymorphism, abstraction, and interfaces in C#. The animal base class and child classes illustrate how methods can be inherited or not. 
# Simple Polymorhpism
AnimalBaseClass has two child classes, Pig and Dog. Pig and Dog each define the virtual method animalSoundVirtual, and pig defines it's own walk() method, while the dog uses the one from the parent class. This is to highlight in a normal base class, methods can be defined in the parent or the child class.
# Simple Abstract Class
AbstractPig and AbstractDog both define the animalSoundAbstract method, which is overridden from the AnimalAbstractClass, to highlight that an abstract method from an abstract class must be defined in the child class, the child class must implement it's own version of the method. 
#Simple Interface
Both the Pig and Dog have to define their own walk and sound methods for the interface, to highlight that interfaces only define method signatures, not the methods themselves, for interface classes.
