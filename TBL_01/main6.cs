using System;

class Program {
    static void Main() {
        Console.WriteLine("Saída:");
        int[] numeros1 = {1, 2, 3};
        int[] numeros2 = numeros1;
        numeros2[0] = 100;
        Console.WriteLine($"numeros1[0] = {numeros1[0]}"); 

        //numeros1[0] foi alterado, pois numeros2 aponta para o mesmo endereço de memória que numeros1.
        //Basta apenas criar o numero2[] sem utilizar numero1[].
        } 
}
