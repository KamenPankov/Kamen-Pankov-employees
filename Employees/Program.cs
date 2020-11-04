using Services;
using System;

namespace Employees
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            Data data = new Data(fileName);            

            Console.WriteLine(data.ToString());
        }

        
    }
}
