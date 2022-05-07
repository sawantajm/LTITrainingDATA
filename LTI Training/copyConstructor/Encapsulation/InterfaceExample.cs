using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    public interface A
    {
        void method1();
        void method2();
    }
    interface B
    {
        void method3();

    }
    class Myclass:B,A
    {
   void B.method3()
        {
            Console.WriteLine("Method3 of B Interface");
        }

        void A.method1()
        {
            Console.WriteLine("Method1 of A Interface");
        }
        void A.method2()
        {
            Console.WriteLine("Method2 of A Interface");
        }
    }
    class InterfaceExample
    {
        public static void Main()
        {
            B b = new Myclass();

            b.method3();

            A a = new Myclass();
            a.method1();
            a.method2();
           
        }
    }
}
