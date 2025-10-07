package aulas;

import java.util.Scanner;

public class Aula_13 {

	public static void main(String[] args) {
		
		final double PI = 3.1415;
		Scanner input = new Scanner(System.in);
		System.out.println("Informe o valor do raio");
		double raio = input.nextDouble();
		
		double area = raio * raio * PI;
		
		System.out.println("O valor da área é "+ area);
		
		
	}

}
