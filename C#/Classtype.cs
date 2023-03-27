namespace Units;
abstract class Unit //추상화 사용을 위해 class 앞에 abstract를 추가
{
    public string Name; //필드를 비워둔다. == public string Name = "Paul"; -> Main 함수에서 객체만들 때 그때그때 수정하기 위해
    public int Damage;
    public int Defence;
    //생성자 start
    public Unit(string name, int damage, int defence)
    {
        Name = name;
        Damage = damage;
        Defence = defence;
    }
    public abstract void moving(int location); //부모 메서드의 결과와 자손 메서드의 결과를 다르게 하기 위해 virtual 사용
   
    
    public abstract void stop();  //추상화 사용을 위해 void 앞에 abstract를 추가
   

}

class Fly : Unit
{
    public string Name2;
    public int Damage2;
    public int Defence2;

     public override void moving(int location) //부모 메서드의 결과와 자손 메서드의 결과를 다르게 하기 위해 virtual 사용
    {
        Console.WriteLine("going {0}만큼ahead",location);
    }
    
    public override void stop()
    {
          Console.WriteLine("Stop");
    }
      public Fly(string name, int damage, int defence) : base(name, damage, defence) //생성자를 만들때에도 상속받기위해 base를 사용
    {
        Name2 = name;
        Damage2 = damage;
        Defence2 = defence;
    }
    public void Flymoving(int location) //부모 메서드의 결과와 자손 메서드의 결과를 다르게 하기 위해 override 사용
    {
    Console.WriteLine("Fying {0}만큼ahead",location);
}
}

class Classtype
{
    static void Main(string[] args) //생성자 함수 덕분에 개체를 정의함과 동시에 속성을 부여할 수 있다.
    { Unit mainunit = new Fly("Marin", 20, 10); //추상화를 하면 new Unit 개체를 만드는 것은 불가능하다.
      Unit mainunit1 = new Fly("Tank", 120, 100);
      Unit mainunit2 = new Fly("Medic", 0, 0);  
      Fly mainunit3 = new Fly("Shuttle",0,0); 

    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit.Name, mainunit.Damage,mainunit.Defence);
    mainunit.moving(2);
    mainunit.stop();
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit1.Name, mainunit1.Damage,mainunit1.Defence);
    mainunit1.moving(3);
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit2.Name, mainunit2.Damage,mainunit2.Defence);
    mainunit2.moving(4);
    Console.WriteLine("{0}유닛은 {1}공격력과 {2}방어력을 가집니다.",mainunit3.Name, mainunit3.Damage,mainunit3.Defence);
    mainunit3.Flymoving(5);
    }
}
