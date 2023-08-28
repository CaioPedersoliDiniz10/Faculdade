package Exercício1;
import java.util.Scanner;
public class SomarDoisNumeros {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int soma=0;
        int x; int y;
        y = input.nextInt();
         x = input.nextInt();

soma = x+y;

System.out.println(soma);
input.close();
    }
    
    
}
