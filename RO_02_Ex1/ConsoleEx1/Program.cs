namespace ExercicioProduto
{
    class Produto
    {
        private string nome;
        private decimal preco;

        public string Nome
        {
            get { return nome; }
        }

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Erro: O preço não pode ser negativo.");
                }
                else
                {
                    preco = value;
                }
            }
        }

        public Produto(string nome, decimal preco)
        {
            this.nome = nome;

            Preco = preco;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Celular", 1500);
            p.ExibirDetalhes();

            p.Preco = -200;
        }
    }
}