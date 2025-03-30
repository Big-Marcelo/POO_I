class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        this.andarAtual = 0; 
    }

    public int AndarAtual
    {
        get { return andarAtual; }
        private set
        {
            if (value >= 0 && value <= totalAndares)
            {
                andarAtual = value;
            }
        }
    }

    public void Subir()
    {
        if (andarAtual < totalAndares)
        {
            andarAtual++;
        }
    }

    public void Descer()
    {
        if (andarAtual > 0)
        {
            andarAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10); 
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual); 
        e.Descer();
        Console.WriteLine(e.AndarAtual); 
        e.Descer();
        e.Descer(); 
        Console.WriteLine(e.AndarAtual); 
    }
}
