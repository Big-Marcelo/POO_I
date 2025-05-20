using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- Lista de Compras ---");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Listar itens");
            Console.WriteLine("4 - Mostrar quantidade total");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do item a ser adicionado: ");
                    string itemAdicionado = Console.ReadLine();
                    listaDeCompras.Add(itemAdicionado);
                    Console.WriteLine($"'{itemAdicionado}' foi adicionado à lista.");
                    break;

                case "2":
                    Console.Write("Digite o nome do item a ser removido: ");
                    string itemRemovido = Console.ReadLine();
                    if (listaDeCompras.Remove(itemRemovido))
                    {
                        Console.WriteLine($"'{itemRemovido}' foi removido da lista.");
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado na lista.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nItens na lista de compras:");
                    if (listaDeCompras.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        foreach (string item in listaDeCompras)
                        {
                            Console.WriteLine($"- {item}");
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine($"Quantidade total de itens: {listaDeCompras.Count}");
                    break;

                case "5":
                    executando = false;
                    Console.WriteLine("Encerrando o programa.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}