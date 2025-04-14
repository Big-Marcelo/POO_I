class Program
{
    static void Main()
    {

        Console.WriteLine("Digite uma frase com espaços no início e no fim, e palavras separadas por vírgulas:");
        string frase = Console.ReadLine();

        frase = frase.Trim();
        Console.WriteLine("\nFrase sem espaços extras:\n" + frase);

        string[] palavras = frase.Split(',');
        Console.WriteLine("\nPalavras separadas:");
        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra.Trim());
        }

        Console.WriteLine("\nDigite a palavra que deseja substituir:");
        string palavraAntiga = Console.ReadLine();

        Console.WriteLine("Digite a nova palavra:");
        string novaPalavra = Console.ReadLine();

        string fraseSubstituida = frase.Replace(palavraAntiga, novaPalavra);
        Console.WriteLine("\nFrase após substituição:\n" + fraseSubstituida);

        Console.WriteLine("\nDigite uma palavra para verificar se a frase começa com ela:");
        string inicio = Console.ReadLine();

        if (frase.StartsWith(inicio))
        {
            Console.WriteLine("A frase começa com \"" + inicio + "\".");
        }
        else
        {
            Console.WriteLine("A frase NÃO começa com \"" + inicio + "\".");
        }

        Console.WriteLine("\nDigite uma palavra para verificar se a frase termina com ela:");
        string fim = Console.ReadLine();

        if (frase.EndsWith(fim))
        {
            Console.WriteLine("A frase termina com \"" + fim + "\".");
        }
        else
        {
            Console.WriteLine("A frase NÃO termina com \"" + fim + "\".");
        }
    }
}