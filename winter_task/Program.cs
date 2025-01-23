using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winter_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если вы хотите создать тест, то напишите *создать*, если вы хотите решать тест, то напишите *решать*");
            string CreatingOrPassingTest = Console.ReadLine();
            if (CreatingOrPassingTest == "создать") Console.WriteLine(" о, арбайтен");
            if (CreatingOrPassingTest == "решать") Console.WriteLine(" о, тоже арбайтен");
            else Console.WriteLine("фу, пиши правильно");
            Console.ReadKey();
        }
    }
}
