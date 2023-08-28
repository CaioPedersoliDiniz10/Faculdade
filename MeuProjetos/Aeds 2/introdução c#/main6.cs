using System;
using System.Collections;

class Program {

    public static void ConcatenaArrayList2(ArrayList al1, ArrayList al2, ArrayList al3) {
        al3.AddRange(al1);
        al3.AddRange(al2);
    }

    public static void Main (string[] args) {
        ArrayList arrayList1 = new ArrayList(){1,2,3,4};
        ArrayList arrayList2 = new ArrayList(){5,6,7,8};
        ArrayList arrayList3 = new ArrayList();

        ConcatenaArrayList2(arrayList1, arrayList2, arrayList3);

        foreach(var item in arrayList3){
            Console.WriteLine(item);
        }
    }
}
