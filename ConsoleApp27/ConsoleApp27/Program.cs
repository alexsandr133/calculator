using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year1 = 2026;
            Console.Title= "Давайте познакомимся";
            Console.WriteLine("введите свое имя и возраст");
            string txt;
            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите год рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите город проживания");
            string city = Console.ReadLine();
            int age = year1 - year;
            txt = $"информация о пользователе:, имя {name}, возраст {age}, город {city}";
            Console.Title = "знакомство состоялось";
            Console.WriteLine(txt);

        }
    }
}
