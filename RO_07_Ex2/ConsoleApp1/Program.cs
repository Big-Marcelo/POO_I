using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> catalogoProdutos = new Dictionary<int, string>();
        int opcao;

        do
        {
            Console.WriteLine("\nCATÁLOGO DE PRODUTOS");
            Console.WriteLine("1. Adicionar novo produto");
            Console.WriteLine("2. Buscar produto por código");
            Console.WriteLine("3. Listar todos os produtos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o código do produto: ");
                    if (!int.TryParse(Console.ReadLine(), out int codigo))
                    {
                        Console.WriteLine("Código inválido.");
                        break;
                    }

                    if (catalogoProdutos.ContainsKey(codigo))
                    {
                        Console.WriteLine("Esse código já está cadastrado.");
                    }
                    else
                    {
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        catalogoProdutos[codigo] = nome;
                        Console.WriteLine("Produto adicionado com sucesso!");
                    }
                    break;

                case 2:
                    Console.Write("Digite o código do produto a buscar: ");
                    if (!int.TryParse(Console.ReadLine(), out int codigoBusca))
                    {
                        Console.WriteLine("Código inválido.");
                        break;
                    }

                    if (catalogoProdutos.TryGetValue(codigoBusca, out string nomeProduto))
                    {
                        Console.WriteLine($"Produto encontrado: {nomeProduto}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nProdutos cadastrados:");
                    if (catalogoProdutos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (var item in catalogoProdutos)
                        {
                            Console.WriteLine($"Código: {item.Key}, Nome: {item.Value}");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 4);
    }
}