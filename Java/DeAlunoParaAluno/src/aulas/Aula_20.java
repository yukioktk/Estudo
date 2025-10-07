package aulas;

import java.util.Scanner;

public class Aula_20 {
	public static void main(String[]args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Insira um número inteiro");
		int numero = input.nextInt();
		
		if((numero % 2 == 0) || (numero < 20)){
			System.out.println("OK");
		}
	}

}
