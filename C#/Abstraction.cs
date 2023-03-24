/*
데이터 추상화는 특정 세부 정보를 숨기고 사용자에게 필수 정보만 표시하는 프로세스입니다. 추상화는 추상 클래스 또는 인터페이스를
사용하여 달성할 수 있습니다 (다음 장에서 자세히 알아볼 것임).

키워드 abstract는 클래스 및 메서드에 사용됩니다.
*/
namespace Animal3;
abstract class Animal 
{
  // Abstract method (does not have a body)
  public abstract void animalSound(); //abstract가 있는 것을 보고 상속을 통해 구현해 주어야 한다는 것을 알 수 있다.
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound() // 클래스에서 상속하고 override키워드를 사용하여 기본 클래스 메서드를 재정의한다는 것을 기억하십시오.
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Abstraction
{
  static void Maintwo(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}