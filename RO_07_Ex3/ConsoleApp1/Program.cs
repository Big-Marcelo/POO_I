using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        int numero;

        Console.WriteLine("Digite números inteiros (digite 0 para parar):");

        do
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero != 0)
                {
                    numerosUnicos.Add(numero);
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
            }

        } while (numero != 0);

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (int n in numerosUnicos)
        {
            Console.WriteLine(n);
        }
    }
}