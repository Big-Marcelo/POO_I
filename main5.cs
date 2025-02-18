using System;

class Program {

  public static void Main(string[] args) {

    string s1 = "Olá";

    string s2 = "Olá";

    string s3 = new string("Olá");



    Console.WriteLine(s1 == s2);   // True

    Console.WriteLine(s1 == s3);   // True

    Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True

    Console.WriteLine(Object.ReferenceEquals(s1, s3)); // False

  }

}

//object.ReferenceEquals(s1, s2) é true se s1 e s2 forem referências para a mesma instância de objeto. 

//object.ReferenceEquals(s1, s3) é false, pois s1 e s3 fazem referências para objetos diferentes.