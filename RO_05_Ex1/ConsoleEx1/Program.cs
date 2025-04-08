class Program
{
    static void Main()
    {
        double[] numeros = new double[5];

        Console.WriteLine("Digite 5 números decimais: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Digite um número decimal válido: ");
            }
        }

        Console.WriteLine("\nResultados: ");
        for (int i = 0; i < 5; i++)
        {
            double numero = numeros[i];
            Console.WriteLine($"\nNúmero {i + 1}: {numero}");
            Console.WriteLine($"Arredondando (Math.Round): {Math.Round(numero)}");
            Console.WriteLine($"Arredondando para baixo (Math.Floor): {Math.Floor(numero)}");
            Console.WriteLine($"Arredondando para cima (Math.Ceiling): {Math.Ceiling(numero)}");
            Console.WriteLine($"Truncado (Math.Truncade: {Math.Truncate(numero)})");

        }
    }
}
