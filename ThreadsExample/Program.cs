
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Example example = new Example();
            example.FirstExmp();
            example.SecondExmp();
            Console.Read();

            Thread firstThread = new Thread(example.FirstExmp);   // multithreading
            Thread  secondThread = new Thread(example.SecondExmp);

            firstThread.Start();
            secondThread.Start();

           
            example.firstExmp(); // asynchronous 
            example.secondExmp(); 

            

        }               
    }
}




        











