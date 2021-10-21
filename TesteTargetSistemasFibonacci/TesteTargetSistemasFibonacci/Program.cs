using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Fibonacci!");
            Console.Write("Insira um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int  i = 0, num1 = 1, num2 = 1;
             
            while (i < num)
            {
                i = num1 + num2;
                Console.WriteLine("Sequência de Fibonacci:" + num1 + "+" + num2 + "=" + i);
                num2 = num1;
                num1 = i;

                if(i == num)
                {
                    Console.WriteLine("Seu número está na sequência!");
                    break;
                }
                else if(i > num)
                {
                    Console.WriteLine("Seu Número não está na Sequência!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
