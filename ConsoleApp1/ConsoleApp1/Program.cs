using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1; ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2; ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Menu");
            Console.WriteLine("1 sumar");
            Console.WriteLine("2 restar");
            Console.WriteLine("3 multiplicar");
            string opc = Console.ReadLine();
            if(opc == "1"){
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            }else if  (opc == "2")   {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            }else if  (opc == "3")   {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            }else {
            Console.WriteLine("Opcion incorrecta");
            } 
            Console.ReadKey();
        }
    }
}
