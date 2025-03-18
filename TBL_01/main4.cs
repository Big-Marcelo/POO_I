using System;


class Program{
  public static void Main (string[] args) {
    string numeroStr;

    Console.Write( "Digite um número: " );
    numeroStr = Console.ReadLine();


    int numero = int.Parse(numeroStr);
    Console.WriteLine( "O número digitado foi: " + numero);
  }
}