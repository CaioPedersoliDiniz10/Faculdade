using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int num1, num2, resultado;
    Console.WriteLine("digite numero 1");
   num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o numero 2");
    num2 =int.Parse(Console.ReadLine());
    resultado = num1 + num2;

    Console.WriteLine(resultado);
  }
}