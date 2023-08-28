using System;
using System.Collections;

class Program {
    class Fila {
        ArrayList elemento = new ArrayList();

        public Fila() {
            for (int i = 0; i < 10; i++) { 
                Console.Write("Inserir número: ");
                int num = int.Parse(Console.ReadLine());
                elemento.Add(num);
            }

            Console.WriteLine("Removendo elementos da fila...");

            while (elemento.Count > 0) {
                int primeiroElemento = (int)elemento[0];
                elemento.RemoveAt(0);
                Console.WriteLine("Elemento removido: " + primeiroElemento);
            }
        }
    }

    public static void Main (string[] args) {
        Fila fila = new Fila();
    }
}
