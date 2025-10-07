package aulas;

public class Aula_15 {

	public static void main(String[] args) {
		
		long totalMilisegundos = System.currentTimeMillis() - 10800000; //unix time pega o horário atual e compara com janeiro de 1970 UTC
															  //compensando diferença de fuso horário
		long totalSegundos = totalMilisegundos / 1000;
		long segundoAtual = totalSegundos % 60;
		
		long totalMinutos = totalSegundos / 60;
		long minutoAtual = totalMinutos % 60;
		
		long totalHoras = totalMinutos / 60;
		long horaAtual = totalHoras % 24;
		
		
		System.out.println(horaAtual+ ":"+ minutoAtual+ ":"+ segundoAtual);
		
		
	}

}
