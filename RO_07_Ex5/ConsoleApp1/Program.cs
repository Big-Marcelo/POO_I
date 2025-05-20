using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Solicita a palavra ao usuário
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        // 2. Cria uma pilha de caracteres
        Stack<char> pilha = new Stack<char>();

        // Empilha cada caractere da palavra
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        // 3. Desempilha para inverter a palavra
        string palavraInvertida = "";
        while (pilha.Count > 0)
        {
            palavraInvertida += pilha.Pop();
        }

        // Exibe a palavra invertida
        Console.WriteLine($"Palavra invertida: {palavraInvertida}");
    }
}