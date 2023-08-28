using System;
using System.Collections;

class Program {
  public static ArrayList Uniao(ArrayList  al1, ArrayList al2){
   ArrayList lista1 = new ArrayList();

    lista1.AddRange(al1);
   foreach(var item in al2){  
    if(! lista1.Contains(item)){
       lista1.Add(item);
    }
     }
    return lista1;

    
  }


  
  public static void Main(string[] args) {

    ArrayList uniao = new ArrayList();
uniao.Add(1);
    uniao.Add(2);
    uniao.Add(3);
    uniao.Add(4);
     ArrayList uniao2 = new ArrayList();

    uniao2.Add(3);
    uniao2.Add(4);
    uniao2.Add(5);
    uniao2.Add(6);

    ArrayList resultado = Uniao(uniao, uniao2);

    foreach(var item in resultado){
  
      Console.WriteLine(item);
      
    }
   
  
    
  }
}
