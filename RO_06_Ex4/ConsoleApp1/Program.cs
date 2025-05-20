using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() 
        : base("Erro: Idade mínima para acesso é 18 anos.") 
    {
    }
}

class Program
{
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException();
        }
        else
        {
            Console.WriteLine("Acesso permitido.");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite um número válido.");
        }
    }
}