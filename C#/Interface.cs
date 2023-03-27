// interface에서는 생성자를 만들수 없다!!
namespace Units_interface;
interface IUnit //interface를 사용하는 경우에는 추상메서드와 속성만 포함할 수 있습니다.
{
    string Name {get; set;}
    int Damage {get;}
    int Defence {get;}

    
  
    void moving(); //추상메서드
    void stop();  //추상메서드
   

}

class Fly : IUnit
{
    public string Name {get; set;}
    public int Damage {get;}
    public int Defence {get;}
   
    public Fly(string name, int damage, int defence)
    {
        Name = name;
        Damage = damage;
        Defence = defence;
    }
    public void moving() //interface를 사용할 경우 override를 사용할 필요가 없다.
    {
        Console.WriteLine("going ahead");
    }
    
    public void stop()
    {
          Console.WriteLine("Stop");
    }
      
    }
  


class Interface
{
    static void Mainclass(string[] args)
    { Fly mainunit = new Fly("marin",10,20); 
      IUnit mainunit1 = new Fly("Tank", 120, 100);
      IUnit mainunit2 = new Fly("Medic", 0, 0);  
      IUnit mainunit3 = new Fly("Shuttle",0,0); 

    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit.Name, mainunit.Damage,mainunit.Defence);
    mainunit.moving();
    mainunit.stop();
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit1.Name, mainunit1.Damage,mainunit1.Defence);
    mainunit1.moving();
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit2.Name, mainunit2.Damage,mainunit2.Defence);
    mainunit2.moving();
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit3.Name, mainunit3.Damage,mainunit3.Defence);
    
    }
}
