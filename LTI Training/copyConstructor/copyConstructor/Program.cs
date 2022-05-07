using System;

namespace copyConstructor
{
    class copyconstructor
    {
        int eid, age;
        string name, Address;

        public copyconstructor()
        {
            Console.WriteLine("Enter Employee details");
            Console.WriteLine("Enter Employee Id");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ter The Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            Address = Console.ReadLine();




        }
        public copyconstructor(copyconstructor temp)
        {
            this.eid = temp.eid;
            this.name=temp.name;
            this.age = temp.age;
            this.Address = temp.Address;


        }
        public void Display()
        {
            Console.WriteLine("Employee id is {0} || Employee Name Is {1}|| Employee Age Is {2} || Employee address is {3} ",this.eid,this.name,this.age,this.Address );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            copyconstructor copyConstructor = new copyconstructor();
            copyconstructor cop1 = new copyconstructor(copyConstructor);
            copyConstructor.Display();
            copyConstructor.Display();
        }
    }
}
