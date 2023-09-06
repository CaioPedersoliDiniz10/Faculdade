import java.util.Scanner;

class Main {

  public boolean isPalindromo(String S) {
    return isPalindromo(S, 0);
  }

  private boolean isPalindromo(String S, int i) {
    if (S.length() / 2 > i) {
      if (S.charAt(i) != S.charAt(S.length() - i - 1)) {
        return false;
      } else {
        return isPalindromo(S, i + 1);
      }
    }
    return true;
  }

  public static void main(String[] args) {
   
    Scanner input = new Scanner(System.in);

    while (true) {
      String s = input.nextLine();
      if (s.equals("FIM")) {
        break;
      }

      Main main = new Main();
      boolean isPalindrome = main.isPalindromo(s);
      if (isPalindrome) {
        System.out.println("SIM");
      } else {
        System.out.println("NAO");
      }
    }
    
    input.close();
  }
}
