
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Example
    {
        public void FirstExmp()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("1 ");
            }
        }
        public void SecondExmp()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("2 ");
            }
        } 
       public async void firstExmp()
        {

            await Task.Delay(1000);
                for (int i = 0; i < 100; i++)
                { 
                 Console.Write("1 "); 
                
                }            
        }
        public async void secondExmp()
        {
            await Task.Delay(1500);
            for (int i =0;i<100;i++)
            {
                Console.Write("2 ");
            }
        }
    }
}
