using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // derivedclass o = new derivedclass();
            // baseclass o = new baseclass();

            //baseclass o = new derivedclass();

            baseclass o = new subderivedclass();
            o.display1();
            o.display();
            Console.ReadLine();
        }
    }
    public class baseclass
    {

        public  void display1()
        {

            Console.WriteLine("base display1");
        }
        public virtual  void display()
        {

            Console.WriteLine("base display");
        }

    }
    public class derivedclass : baseclass
    {
        public void display1()
        {

            Console.WriteLine("derived display");
        }
        public override void display()
        {

            Console.WriteLine("derived display");
        }

    }
    public class subderivedclass : derivedclass
    {
        public void display1()
        {

            Console.WriteLine("subderived display");
        }
        public override void display()
        {

            Console.WriteLine("subderived  overide display");
        }

    }
}
