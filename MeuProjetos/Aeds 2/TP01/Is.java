import java.util.Scanner;
public class Main {
    public static boolean iterativo(String teste){
        boolean resp = true;
        String vogal = "aeiouAEIOU";
        int j;

        for(int i=0; i<teste.length(); i++){
            resp = false;
            for(j=0; j<vogal.length(); j++){
                if(teste.charAt(i)== vogal.charAt(j)){
                    resp = true;
                    break;
                }
            }
            if(!resp){
                return false;
            }
        }

        return true;
  
    }
  static boolean isConsoante(String entrada) {
        for (int i = 0; i < entrada.length(); i++) {
            char c = Character.toUpperCase(entrada.charAt(i));
            if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || !Character.isLetter(c)) {
                return false;
            }
        }
        return true;
    }
   static boolean isInteiro(String entrada) {
        try {
            Integer.parseInt(entrada);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
    
    static boolean isReal(String entrada) {
        try {
            Double.parseDouble(entrada);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
    
    

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        while(true){ 
        String teste =input.nextLine();
      if(teste.equals("FIM")){
        break;
      }
          else{ 
      boolean vogal= iterativo(teste);
       boolean consoante = isConsoante(teste);
            boolean inteiro = isInteiro(teste);
                boolean real = isReal(teste);

                System.out.println((vogal ? "SIM" : "NAO") + " " + (consoante ? "SIM" : "NAO") 
                      + " " +
                        (inteiro ? "SIM" : "NAO") + " " + (real ? "SIM" : "NAO"));
       
      
        }
      
        }


    }
}