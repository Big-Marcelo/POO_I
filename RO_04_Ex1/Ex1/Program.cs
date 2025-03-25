public abstract class Pagamento
{
    public abstract void ProcessarPagamento();
}

public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Cartão de Crédito.");
    }
}

public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Boleto Bancário.");
    }
}

public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Pix.");
    }
}

class Program
{
    static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>
        {
            new CartaoCredito(),
            new BoletoBancario(),
            new Pix()
        };

        foreach (var pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}