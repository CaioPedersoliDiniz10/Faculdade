using System;
using System.Collections;

class Program
{
    public static ArrayList CopiarArrayList(ArrayList origem)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.AddRange(origem);
  
        return arrayList;
    }

    public static void Main(string[] args)
    {
        ArrayList origem = new ArrayList() { 1, 2, 3, 4, 5 };

        Console.WriteLine("Elementos da origem:");

        foreach (var item in origem)
        {
            Console.WriteLine(item);
        }

        ArrayList copiado = CopiarArrayList(origem);

        Console.WriteLine("Elementos copiados:");

        foreach (var item in copiado)
        {
            Console.WriteLine(item);
        }
    }
}

