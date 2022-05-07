using System;

namespace Mehos_Hidin
{
    class Program
    {
        public class class1
        {
            public void display()
            {
                Console.WriteLine("Supper class Display method");
            }
        }

        public class class2 : class1
        {
            public new void display()
            {
                Console.WriteLine("Sub class Diaplay method ");
            }
        }
        static void Main(string[] args)
        {
            class1 obj = new class2();
            obj.display();
            
        }
    }
}
