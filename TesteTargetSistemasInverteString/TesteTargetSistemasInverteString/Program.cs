using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemasInverteString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua frase:");
            string StrOriginal = Console.ReadLine();
            string StrNova = string.Empty;
            for(int i = (StrOriginal.Length -1 );i >= 0; i--)
            {
                StrNova += Convert.ToString(StrOriginal[i]);
            }
            Console.WriteLine("String Invertida:" + StrNova);
            Console.ReadKey();

            

        }
    }
}
