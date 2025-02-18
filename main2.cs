using System;

public class Pessoa {
  public string Nome;
}

class Program{
  public static void Main (string[] args) {
    Pessoa p1 = new Pessoa();
    p1.Nome = "Ronaldo";
    Pessoa p2 = new Pessoa();
    p2.Nome = "Marcelo";
    p1 = p2;
    Console.WriteLine ($"Nome 1: {p1.Nome}, Nome 2: {p2.Nome}");
  }
}
