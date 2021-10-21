using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TesteTargetSistemaJSON.Serializar;

namespace TesteTargetSistemaJSON
{
    class Program
    {

        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Dados.json");

            var dados = JsonConvert.DeserializeObject<List<Dados>>(json);
            Console.WriteLine("Calculos Faturamento! \nPor: João Vitor Girardi Stahl");
            Console.WriteLine("Pressione Qualquer Tecla para Calcular o MENOR e o MAIOR faturamento ocorrido em um dia do mês.");
            Console.ReadKey();

            double MenorFat = 0, MaiorFat = 0;

            for( int i =0; i < dados.Count; i++)
            {
                if(dados[i].Valor > 0)
                {
                    if (i == 0)
                    {
                        MenorFat = dados[i].Valor;
                        MaiorFat = dados[i].Valor;
                    }
                    if (dados[i].Valor < MenorFat)
                    {
                        MenorFat = dados[i].Valor;
                    }
                    else if (dados[i].Valor > MaiorFat)
                    {
                        MaiorFat = dados[i].Valor;
                    }
                }
                
            }
            Console.WriteLine("Menor Faturamento:" + MenorFat);
            Console.WriteLine("Maior Faturamento:" + MaiorFat);
            Console.WriteLine("Pressione Qualquer Tecla para calcular  Número de dias no mês em que o valor de faturamento diário foi superior à média mensal!");
            Console.ReadKey();
            double media = 0, soma = 0;
            int qtdDias = 0;
            for(int i = 0; i < dados.Count; i++)
            {
                if(dados[i].Valor != 0)
                {
                    soma += dados[i].Valor;
                }
            }
            media = soma / dados.Count;
            for(int i=0; i < dados.Count; i++)
            {
                if(dados[i].Valor != 0)
                {
                    if(dados[i].Valor > media)
                    {
                        qtdDias++;
                    }
                } 
            }
            Console.WriteLine(qtdDias + " Dias obtiveram Faturamento acima da media mensal!");
            Console.WriteLine("Pressione Qualquer Tecla para encerrar!");
            Console.ReadKey();
        }
    }
}
