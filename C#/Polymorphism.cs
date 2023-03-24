/*
다형성은 "많은 형태"를 의미하며 상속을 통해 서로 관련된 많은 클래스가 있을 때 발생합니다.

이전 장에서 지정한 것처럼; 상속을 통해 다른 클래스에서 필드와 메서드를 상속할 수 있습니다. 다형성은 이러한 방법을 사용하여 다른 작업을 수행합니다. 이를 통해 단일 작업을 다양한 방식으로 수행할 수 있습니다.
*/

using System;

namespace Animal2; // inheritance.cs 에서 class Animal이랑 중첩이 되기 때문에 namespace를 사용한다.
class Animal  // Base class (parent) 
{
  public virtual void animalSound() // 파생클래스 메서드에 대한 키워드를 virtual로 사용
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound()  //override 재정의 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Polymorphism 
{
  static void Mains(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}