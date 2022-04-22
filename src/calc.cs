using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungnaeConsole
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 연산자 (더하기, 빼기, 곱하기, 나누기)
      Console.WriteLine(2+4); // 6
      Console.WriteLine(4-2); // 2
      Console.WriteLine(2*4); // 8
      Console.WriteLine(4/2); // 2
      Console.WriteLine(4%2); // 0
      
      // 증감연산자
      Console.WriteLine(1++);
      Console.WriteLine(++1);
      Console.WriteLine(1--);
      Console.WriteLine(--1);
      
      // 할당연산자
      int a = 100;
      a += 10; // 110
      a -= 10; // 100
      a *= 100; // 10000
      a /= 10; // 1000
      a %= 10; // 0
      
      // 논리연산자
      Console.WriteLine(true&&true); // True
      Console.WriteLine(false&&true); // False * (false 부분은 평가되지만, true 부분은 평가되지 않음)
      Console.WriteLine(true||false); // True * (true 부분은 평가되지만, false 부분은 평가되지 않음)
      Console.WriteLine(false||true); // True
      Console.WriteLine(!true); // False
      Console.WriteLine(!false); // True
    }
  }
}
