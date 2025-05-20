using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do produto não pode estar em branco.");
            }

            Console.Write("Digite o preço do produto: ");
            string inputPreco = Console.ReadLine() ?? "";

            if (!decimal.TryParse(inputPreco, out decimal preco))
            {
                throw new FormatException("Preço inválido. Insira um valor numérico.");
            }

            if (preco <= 0)
            {
                throw new ArgumentOutOfRangeException("preço", "O preço deve ser maior que zero.");
            }

            Console.WriteLine($"\nProduto cadastrado com sucesso!");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}