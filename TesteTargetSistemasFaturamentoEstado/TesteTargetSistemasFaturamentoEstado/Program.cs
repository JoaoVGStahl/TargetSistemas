using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemasFaturamentoEstado
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] PorcFaturamento = new double[5];
            double[] Faturamento = new double[5];
            Faturamento[0] = 67836.43; // SP
            Faturamento[1] = 367678.66; // RJ
            Faturamento[2] = 29229.88; // MG
            Faturamento[3] = 27165.48; // ES
            Faturamento[4] = 19849.53; // OUTROS
            double Total = 0;

            for(int i = 0; i < Faturamento.Length; i++)
            {
                Total += Faturamento[i];
            }
            for(int i =0; i < Faturamento.Length; i++)
            {
                PorcFaturamento[i] = (Faturamento[i] * 100) / Total;
            }
            Console.WriteLine("Com Formatação:");
            Console.WriteLine("Faturamento SP:" + PorcFaturamento[0].ToString("N2") + "%");
            Console.WriteLine("Faturamento RJ:" + PorcFaturamento[1].ToString("N2") + "%");
            Console.WriteLine("Faturamento MG:" + PorcFaturamento[2].ToString("N2") + "%");
            Console.WriteLine("Faturamento ES:" + PorcFaturamento[3].ToString("N2") + "%");
            Console.WriteLine("Faturamento OUTROS:" + PorcFaturamento[4].ToString("N2") + "%");
            Console.ReadKey();





        }
    }
}
