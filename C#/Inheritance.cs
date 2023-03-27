//상속1 -> 함수의 이름이 동일하기 때문에 모두 동일한 결과를 출력한다.
using System;
namespace Animal; // Abstraction.cs 에서 class Animal이랑 중첩이 되기 때문에 namespace를 사용한다.
class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public new void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public new void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Inheritance 
{
  static void Run(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
} 