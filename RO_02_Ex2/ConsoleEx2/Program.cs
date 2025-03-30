namespace ExercicioCarro
{
    class Carro
    {

        private string modelo;
        private int velocidadeAtual;

        public string Modelo
        {
            get { return modelo; }
        }

        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            private set
            {
                if (value < 0)
                {
                    velocidadeAtual = 0;
                }
                else
                {
                    velocidadeAtual = value;
                }
            }
        }

        public Carro(string modelo)
        {
            this.modelo = modelo;
            velocidadeAtual = 0;
        }

        public void Acelerar(int valor)
        {
            if (valor > 0)
            {
                VelocidadeAtual += valor;
            }
            else
            {
                Console.WriteLine("O valor para acelerar deve ser positivo.");
            }
        }

        public void Frear(int valor)
        {
            if (valor > 0)
            {
                VelocidadeAtual -= valor;
            }
            else
            {
                Console.WriteLine("O valor para frear deve ser positivo.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro("Ferrari");

            c.Acelerar(50);
            Console.WriteLine(c.VelocidadeAtual);

            c.Frear(30);
            Console.WriteLine(c.VelocidadeAtual);

            c.Frear(50);
            Console.WriteLine(c.VelocidadeAtual);
        }
    }
}