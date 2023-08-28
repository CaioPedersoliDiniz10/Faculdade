using System;
using System.Collections;

class Program {
    public static int QtdeOcorrencias(ArrayList al, object elemento) {
        int count = 0;

        foreach (var item in al) {
            if (item.Equals(elemento)) {
                count++;
            }
        }

        return count;
    }

    public static void Main (string[] args) {
        ArrayList ocorrencia = new ArrayList(){1, 2, 3, 4, 4, 4, 5, 4, 6, 7, 4, 8};

        int quantidade = QtdeOcorrencias(ocorrencia, 4);

        Console.WriteLine($"O elemento 4 ocorre {quantidade} vezes");
    }
}
