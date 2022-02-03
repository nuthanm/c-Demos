/*
  Inheritence allows us to define a class(Derived Class) based on another class(Base Class).
  Base class: The class whose properties(Base class properties) are inherited by another class (Derived class)
  Derived class: The class which iherits the properties by itself
  Ex: Animal (Base class)
    cat & dog are derived class
    cat & dog inherits Animal properties and methods, also each derived has its own properites and methods.
    Advantage of Inheritence: Reuse Base class properties and methods in Derived class and Derived class extends the functionality of base class.
*/
using System;
					
public class Program
{
	public static void Main()
	{
		Dog dog = new Dog();
		dog.Bark();
		
    // Because we inherited Animal Base class to Dog Derived one. So that all properties of Base class can directly access from Derived
		Console.WriteLine(dog.Legs); 		
	}
}

class Animal{
	public int Legs {get; set;}
}

class Dog : Animal{
	public Dog(){
		Legs = 4;
	}
	
	public void DogLegs()
	{
		Console.WriteLine("Dog has {0} legs", Legs);
	}
	public void Bark()
	{
		Console.WriteLine("Woof");
	}	
}
