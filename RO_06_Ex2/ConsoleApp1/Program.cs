using System;

class Program
{
    static void Main()
    {
        float temperatura = LerTemperaturaCelsius();
        Console.WriteLine($"Temperatura informada: {temperatura} °C");
    }

    static float LerTemperaturaCelsius()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine() ?? "";

                if (!float.TryParse(entrada, out float celsius))
                {
                    throw new FormatException("Valor inválido. Digite um número válido para a temperatura.");
                }

                return celsius;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}