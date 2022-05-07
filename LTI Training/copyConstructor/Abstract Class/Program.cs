using System;

namespace Abstract_Class
{

   public  abstract  class AbstarctClass
    {
        
       public  abstract double  Addition(double firstno, double secondno);

    }
    
    public class Derivedclass:AbstarctClass
    {
        public override double  Addition(double firstno, double secondno)
        {
            

            double result = firstno + secondno;
            Console.WriteLine(result);
            return  result;
        }
  
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            double firstno, secondno;
            Console.WriteLine("Enter The First number");
            firstno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Second No");
            secondno = Convert.ToDouble(Console.ReadLine());


            AbstarctClass derivedclass = new Derivedclass();
            derivedclass.Addition(firstno,secondno);
        }
    }
}
