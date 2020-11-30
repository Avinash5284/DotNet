using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)

        {
            System.Console.WriteLine("hello world");
            System.Console.ReadLine();
            Console.WriteLine("system");
            Console.ReadLine();

            class1 c1 = new class1();
            c1.Display();

            Console.WriteLine(c1.Add(10, 20, 30, 40));
            Console.WriteLine(c1.Add(10, 20, 30));
            Console.WriteLine(c1.Add(10, 20));
            Console.WriteLine(c1.Add(10));
            Console.WriteLine(c1.Add());


       //named Parameters
            Console.WriteLine(c1.Add(d:40));
            Console.WriteLine(c1.Add(c:20));
            Console.WriteLine(c1.Add(a:10,c: 20));

            Console.WriteLine(c1.Add2(a: 10, c: 20,b:100,d:200));


        }
    }
   public class class1 {

        public void Display()
        {

            System.Console.WriteLine("hello world");
        }

        public int Add(int a = 0, int b = 0, int c = 0, int d = 0) 
        
        {

            return a + b + c + d;
        }

        public int Add2(int a , int b, int c, int d)

        {

            return a + b + c + d;
        }
    }
}
