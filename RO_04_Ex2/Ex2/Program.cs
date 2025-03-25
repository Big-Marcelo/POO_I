public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public double SalarioBase { get; set; }

    public Funcionario(string nome, string matricula, double salarioBase)
    {
        Nome = nome;
        Matricula = matricula;
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}
public class Gerente : Funcionario
{
    public Gerente(string nome, string matricula, double salarioBase)
        : base(nome, matricula, salarioBase)
    {
    }

    public override double CalcularSalario()
    {
        return 2 * SalarioBase;
    }
}

public class Programador : Funcionario
{
    public Programador(string nome, string matricula, double salarioBase)
        : base(nome, matricula, salarioBase)
    {
    }

    public override double CalcularSalario()
    {
        return SalarioBase + (0.10 * SalarioBase);
    }
}

public class Program
{
    public static void Main()
    {
        Funcionario gerente = new Gerente("Ana", "G001", 5000);
        Funcionario programador = new Programador("Marcelo", "P001", 4000);

        Console.WriteLine($"Salário de {gerente.Nome}: R$ {gerente.CalcularSalario():F2}");
        Console.WriteLine($"Salário de {programador.Nome}: R$ {programador.CalcularSalario():F2}");
    }
}