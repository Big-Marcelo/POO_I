public class Item
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    
    public Item(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

public class Pedido
{
    public int Numero { get; set; }
    public List<Item> Itens { get; set; }
    
    public Pedido(int numero)
    {
        Numero = numero;
        Itens = new List<Item>();
    }
    
    public void AdicionarItem(Item item)
    {
        Itens.Add(item);
    }
    
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in Itens)
        {
            total += item.Preco;
        }
        return total;
    }
}

public class Program
{
    public static void Main()
    {
        Pedido pedido = new Pedido(1);
        pedido.AdicionarItem(new Item("Produto A", 10.50m));
        pedido.AdicionarItem(new Item("Produto B", 20.75m));
        
        Console.WriteLine("Total do pedido: " + pedido.CalcularTotal());
    }
}
