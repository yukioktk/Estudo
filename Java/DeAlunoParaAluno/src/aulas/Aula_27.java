package aulas;

import java.util.Scanner;

public class Aula_27 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Selecione um número de 1 a 5");
		int num = input.nextInt();
		
		switch(num) {
		case 1:
			System.out.println("Você escolheu 1");
			break;
		case 2:
			System.out.println("Você escolheu 2");
			break;
		case 3:
			System.out.println("Você escolheu 3");
			break;
		case 4:
			System.out.println("Você escolheu 4");
			break;
		case 5:
			System.out.println("Você escolheu 5");
			break;
		default:
			System.out.println("Numero inválido");
			
		}
		
	}

}
