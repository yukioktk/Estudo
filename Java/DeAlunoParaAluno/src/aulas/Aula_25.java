package aulas;

import java.util.Scanner;
import java.util.Random;

public class Aula_25 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		Random random = new Random();
		
		boolean acertou = false;
		int tentativas = 10;
		int numeroSecreto = random.nextInt();
		long chute = 0;
		
		System.out.println("Número secreto "+ numeroSecreto);
		while(tentativas > 0 && acertou == false) {
			 System.out.println("Qual seu chute?");
			 chute = input.nextLong();
			 
			 if(chute == numeroSecreto) {
				 System.out.println("Você acertou!");
				 acertou = true;
				 
			 } else if(chute < numeroSecreto){
				 tentativas--;
				 System.out.println("Número muito pequeno! "+ tentativas+ " tentativas restantes.");
				 
			 } else {
				 tentativas--;
				 System.out.println("Número muito grande! "+ tentativas+ " tentativas restantes.");
				 
			 }
			 
				 
			
		}
		
		
	}

}
