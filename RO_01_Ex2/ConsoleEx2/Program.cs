namespace PacMan
{
    class Fantasma
    {
        public string Habilidade { get; set; }
        public string Nick { get; set; }
        public string Cor { get; set; }

        public void GerarFantasma()
        {
            Console.WriteLine($"Fantasma gerado!");
            Console.WriteLine($"Nick: {Nick}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Habilidade: {Habilidade}");
        }

        public void Mover(string direcao)
        {
            Console.WriteLine($"{Nick} se moveu para {direcao}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fantasma fantasma1 = new Fantasma
            {
                Nick = "Marcelo",
                Cor = "Vermelho",
                Habilidade = "Seguir o jogador"
            };

            fantasma1.GerarFantasma();

            fantasma1.Mover("norte");
        }
    }
}