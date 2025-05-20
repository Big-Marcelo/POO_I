using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaDeClientes = new Queue<string>();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n=== Menu da Fila de Atendimento ===");
            Console.WriteLine("1 - Adicionar cliente à fila");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver quantidade de clientes na fila");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string nomeCliente = Console.ReadLine();
                    filaDeClientes.Enqueue(nomeCliente);
                    Console.WriteLine($"Cliente {nomeCliente} adicionado à fila.");
                    break;

                case "2":
                    if (filaDeClientes.Count > 0)
                    {
                        string clienteAtendido = filaDeClientes.Dequeue();
                        Console.WriteLine($"Cliente atendido: {clienteAtendido}");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia. Nenhum cliente para atender.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Número de clientes na fila: {filaDeClientes.Count}");
                    break;

                case "4":
                    executando = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}