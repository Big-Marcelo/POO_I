using System;
using System.Globalization;

class Program
{
    static void Main()
    {
  
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        string entrada = Console.ReadLine();

        DateTime compromisso;
        bool sucesso = DateTime.TryParseExact(
            entrada,
            "dd/MM/yyyy HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out compromisso
        );

        if (!sucesso)
        {
            Console.WriteLine("Formato de data/hora inválido.");
            return;
        }

        DateTime agora = DateTime.Now;
        TimeSpan diferenca = compromisso.Date - agora.Date;
        int diasFaltando = diferenca.Days;

        string diaSemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));

        string dataFormatada = compromisso.ToString("dd/MM/yyyy 'às' HH:mm");

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3}",
            nome,
            diasFaltando,
            diaSemana,
            dataFormatada
        );

        Console.WriteLine();
        Console.WriteLine(mensagem);
    }
}