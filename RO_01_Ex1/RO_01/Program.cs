public class Pessoa
{
    public string Nome, Cargo;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }

    public void InformarSalario()
    {
        int salario = Cargo switch
        {
            "Gerente" => 10000,
            "Desenvolvedor" => 5000,
            "Estagiário" => 1000,
            _ => 0
        };
        Console.WriteLine($"Salário de {Cargo}: R${salario:N2}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa { Nome = "João", Idade = 30, Cargo = "Gerente" };
        Pessoa p2 = new Pessoa { Nome = "Maria", Idade = 25, Cargo = "Desenvolvedor" };
        Pessoa p3 = new Pessoa { Nome = "José", Idade = 22, Cargo = "Estagiário" };
        

        List<Pessoa> pessoas = new List<Pessoa> { p1, p2, p3};

        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.Apresentar();
            pessoa.InformarSalario();
        }
    }
}
