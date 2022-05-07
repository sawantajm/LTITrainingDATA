using System;

namespace String
{
    class Program
    {

        //Recursion

        int num = 1;
        void counting()
        {
            if(num==11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            counting();
        }
        static void Main(string[] args)
        {
            string Firstname = "Ajinath"; //use small String Keyword
            string Lastname = "Sawant";
            string str;
            str =(Firstname + " " + Lastname);
           
            Console.WriteLine(str);

            //create object for recurssion
            Program program = new Program();
                program.counting();

            //call By value And Call By refrence

            //Convert.Tostrin And ToString

            Program program1 = null;
            // program1.ToString();    //Showing Exceptipn program1 was null using ToString() fun
            string Name = null;
            Convert.ToString(Name);
            Convert.ToString(program1);

        }
    }
}
