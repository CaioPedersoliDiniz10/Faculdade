using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Informe o número de alunos:");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] notas = new int[n];
        int somaNotas = 0;

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Informe o nome do aluno {i + 1}:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Informe a nota do aluno {i + 1}:");
            notas[i] = int.Parse(Console.ReadLine());

            somaNotas += notas[i];
        }

        int media = somaNotas / n;
        Console.WriteLine($"Média do grupo: {media}");

        Console.WriteLine("Alunos acima da média:");
        for (int i = 0; i < n; i++) {
            if (notas[i] > media) {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
