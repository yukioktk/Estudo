package aulas;

import java.util.Scanner;

public class Aula_14 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Insira o valor em gramas");
		int gramas = input.nextInt();
		
		int kilos = gramas / 1000;
		gramas = gramas % 1000;
		
		System.out.println("O Total de kilos é = "+ kilos);
		System.out.println("O Total de gramas é = "+ gramas);
	}

}
