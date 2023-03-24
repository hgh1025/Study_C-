/*
명령문 try을 사용하면 실행되는 동안 오류를 테스트할 코드 블록을 정의할 수 있습니다.

이 catch명령문을 사용하면 try 블록에서 오류가 발생하는 경우 실행할 코드 블록을 정의할 수 있습니다.
*/
static void checkAge(int age)
{
  if (age < 18)
  {
    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
  }
  else
  {
    Console.WriteLine("Access granted - You are old enough!");
  }
}

static void Main(string[] args)
{
  checkAge(15);
}