using System;
using System.Collections;

class Program {
    class Pilha {
        ArrayList elemento = new ArrayList();

        public Pilha() {
            for (int i = 0; i < 10; i++) { 
                Console.Write("Inserir número: ");
                int num = int.Parse(Console.ReadLine());
                elemento.Add(num);
            }

            Console.WriteLine("Removendo elementos da pilha...");

            while (elemento.Count > 0) {
                int ultimoElemento = (int)elemento[elemento.Count - 1]; 
                elemento.RemoveAt(elemento.Count - 1);
                Console.WriteLine("Elemento removido: " + ultimoElemento);
            }
        }
    }

    public static void Main (string[] args) {
        Pilha pilha = new Pilha();
    }
}
