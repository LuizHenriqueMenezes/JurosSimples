using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular o montante final de um investimento a juros simples, para isso, digite:");

            Console.WriteLine("Capital [c] (R$):");
            double capital = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Taxa de juros [i] (%):");
            double taxa = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Tempo [t] (meses):");
            double tempo = Convert.ToDouble(Console.ReadLine()); 

            double juros = capital * (taxa/100) * tempo; 
            Console.WriteLine($"Juros (R$): {juros}");

            double montante = capital + juros;
            Console.WriteLine($"Montante (R$): {montante}");

        }
    }
}
