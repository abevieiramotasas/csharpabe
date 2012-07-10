using System;

namespace Bereu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Teste t = new Teste();
			for(int contador=0; contador < 100; contador++) 
			{
				t.valor = contador;
				System.Console.Write(t.valor);
			}
		}
	}
	
	class Teste
	{
		public double valor;
	}
}
