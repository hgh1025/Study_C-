/*
C#에서 추상화를 달성하는 또 다른 방법은 인터페이스를 사용하는 것입니다.

An interface은 완전히 " 추상 클래스 "이며 추상 메서드와 속성(빈 본문 포함)만 포함할 수 있습니다.

인터페이스 시작 부분에 "I" 문자로 시작하는 것이 좋은 습관으로 간주됩니다. 
이렇게 하면 자신과 다른 사람들이 인터페이스가 클래스가 아니라 인터페이스임을 쉽게 기억할 수 있기 때문입니다.
*/
using System;
namespace mutiinterface;
// Interface
interface IAnimal 
{
    
  void animalSound(); // interface method (does not have a body)
// interface는 멤버변수도 가질수 없다. ex)private string a = 'hi', public int a = 10

/* interface는 아래와 같이 일반매서드를 가질 수 없다.
 public void sleep()
  {
    Console.WriteLine("Zzz");
  }
*/

}
interface IAnimal2
{
    void myanimalSound();
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal , IAnimal2 // 다중 인터페이스를 사용 할 경우 , 를 사용한다.
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
  public void myanimalSound() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Interface 
{
  static void Maininterface(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
    myPig.myanimalSound();
  }
}

