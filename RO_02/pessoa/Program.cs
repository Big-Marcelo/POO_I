using System;

public class Pessoa
{
    public string nome;
    public string rg;
}
public class Vendedor : Pessoa
{
    public double comissao;
}
class Program
{
    static void Main()
    {
    Vendedor vendedor = new Vendedor(); // Corrigido
    vendedor.nome = "Maria";
    vendedor.comissao = 1.1;

    Pessoa pessoa = new Pessoa(); // Corrigido
    pessoa.nome = "Joao";

    Console.WriteLine(pessoa.nome);
    Console.WriteLine(vendedor.nome);
    Console.WriteLine(vendedor.comissao);

    }   
}
