using System;
using System.Collections;

class Program {

    public static ArrayList OcorrenciasDe(ArrayList al, object elemento) {
        ArrayList ocorrencias = new ArrayList();

        for (int i = 0; i < al.Count; i++) {
            if (al[i].Equals(elemento)) {
                ocorrencias.Add(i);
            }
        }

        return ocorrencias;
    }

    public static void Main(string[] args) {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(2);

        ArrayList posicoes = OcorrenciasDe(arrayList, 2);

        Console.WriteLine("O elemento 2 aparece nas posições:");
        foreach (int posicao in posicoes) {
            Console.WriteLine(posicao);
        }
    }
}
