import java.io.*;
import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void semRecursao(String nomeArquivo) {
        try (RandomAccessFile arquivo = new RandomAccessFile(nomeArquivo, "r")) {
            List<Double> numeros = new ArrayList<>();

            String linha;
            while ((linha = arquivo.readLine()) != null) {
                double numero = Double.parseDouble(linha);
                numeros.add(numero);
            }

            Collections.reverse(numeros);

            for (double numero : numeros) {
                System.out.println(numero);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        String nomeArquivo = "numeros.txt";
        Scanner scanner = new Scanner(System.in);

        try {
            FileWriter arquivo = new FileWriter(nomeArquivo);

      
            int n = scanner.nextInt();

            for (int i = 0; i < n; i++) {
               
                double numero = scanner.nextDouble();
                arquivo.write(numero + "\n");
            }

            arquivo.close();
        } catch (IOException e) {
            System.out.println("Erro na abertura/escrita de arquivo.");
        } finally {
            scanner.close();
        }

        semRecursao("numeros.txt");
    }
}
