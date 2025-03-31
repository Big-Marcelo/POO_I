class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au Au!");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal("Gato");
        animal.EmitirSom();

        Cachorro cachorro = new Cachorro("Gato");
        cachorro.EmitirSom();
    }
}
