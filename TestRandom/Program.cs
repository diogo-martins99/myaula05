using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDices;
            Random randomNumber = new Random();
            int sum = 0;

            Console.WriteLine("Insert Number of Dices: ");
            numberOfDices = Convert.ToInt32(Console.ReadLine());
             for( int i = 0; i < numberOfDices; i++)
            {
                sum += randomNumber.Next(1,7);
            }

            Console.WriteLine("A soma dos dados é igual a: " + sum);
        }
    }
}
