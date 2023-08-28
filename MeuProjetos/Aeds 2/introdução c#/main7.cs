using System;
using System.Collections;

class Program {

    public static ArrayList  Uniao( ArrayList al1,  ArrayList al2) {
       ArrayList al3 = new ArrayList();
       al3.AddRange(al1);

      foreach(var item2 in al2){
        if(!al3.Contains(item2)){
          al3.Add(item2);
        }
      }
      return al3;
    }

  
  public static void Main (string[] args) {

    ArrayList  arrayList = new ArrayList(){1,2,3,4};
     ArrayList  arrayList2 = new ArrayList(){3,4,5,6};

     ArrayList uniao =  Uniao(arrayList, arrayList2);

       foreach(var item2 in uniao){
         Console.WriteLine(item2);
       }
   
  }
}