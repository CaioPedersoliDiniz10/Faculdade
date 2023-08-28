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
              Console.Write("Inserir aluno: ");
              string num = (Console.ReadLine());
              arrayList.Add(num);
           break;

          case 2:
          Console.Write("Remover aluno: ");
         string remo = (Console.ReadLine());
  if (arrayList.Contains(remo)){
    arrayList.Remove(remo);
    Console.Write("Removido");
    }
    else {
    Console.Write("Erro na remoção , seu alunonão existe");
    }
  
                    break;

       case 3:
            Console.WriteLine("Listando:");
              foreach (var item in arrayList) {
            Console.Write(item + " ");
            }
          Console.WriteLine(); 
              break;

     case 4:
           Console.Write("Aluno pesquisado: ");
        string pesq = (Console.ReadLine());
        if (arrayList.Contains(pesq)) {
            Console.WriteLine($"Aluno {pesq} encontrado na lista.");
           } else {
           Console.WriteLine("Aluno não encontrado.");
           }
           break;

                case 5:
                    Console.Write("Ordenando...\n");
                    arrayList.Sort();
                    Console.Write("Alunos ordenadas.\n");
                    foreach(var item in arrayList){
                      Console.WriteLine(item);
                    }
                    
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
