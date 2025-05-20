using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou o número: " + numero);
        }
        catch
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }
}
