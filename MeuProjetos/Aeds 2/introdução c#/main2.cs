using System;
using System.Collections;

class Program {
    public static void Main(string[] args) {
        ArrayList arrayList = new ArrayList();

        while (true) {
            Console.WriteLine("1- Inserir\n2- Remover\n3- Listar\n4- Pesquisar\n5- Ordenar\n6- Sair");
            int opcao = int.Parse(Console.ReadLine());

switch (opcao) {
          case 1:
              Console.Write("Inserir número: ");
              int num = int.Parse(Console.ReadLine());
              arrayList.Add(num);
           break;

          case 2:
          Console.Write("Remover número: ");
         int remo = int.Parse(Console.ReadLine());
        arrayList.Remove(remo);
  if (remo >= 0 && remo < arrayList.Count) {
           Console.Write("Removido!\n");
           } else {
        Console.Write("ERRO NA REMOÇÃO!\n");
     }
                    break;

       case 3:
            Console.WriteLine("Listando os valores:");
              foreach (var item in arrayList) {
            Console.Write(item + " ");
            }
          Console.WriteLine(); 
              break;

     case 4:
           Console.Write("Número a ser pesquisado: ");
        int pesq = int.Parse(Console.ReadLine());
        if (arrayList.Contains(pesq)) {
            Console.WriteLine($"Valor {pesq} encontrado na lista.");
           } else {
           Console.WriteLine("Valor não encontrado.");
           }
           break;

                case 5:
                    Console.Write("Ordenando...\n");
                    arrayList.Sort();
                    Console.Write("Lista ordenada.\n");
                    break;

     case 6:
       Console.WriteLine("Saindo do programa.");
          return;

        default:
      Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                    break;
            }
        }
    }
}
