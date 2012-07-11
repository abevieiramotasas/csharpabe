using System;

namespace Bereu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Pessoa p = new Pessoa();
			Bola b = new Bola();
			b.raio = 10.0;
			b.dono = p;
			System.Console.WriteLine(b.NomeDoMeuDonoUpperCamelCaseUmaBosoca("Nome: "));
			array();
		}
		
		public static void array()
		{
			int[] numeros = new int[10];
			for(int i=0; i < 10; i++)
			{
				numeros[i] = i*i;
			}
			foreach(int i in numeros)
			{
				System.Console.Write(i);
			}
			// ou - estranho, o Length nao aparece no spell completation
			/* for(int i=0; i<numeros.Length; i++)
			{
				System.Console.Write(numeros[i]);
			} */
			string[] nomes = new string[]{"abelardo", "juliana"};
			System.Array.Sort(nomes);
			string[] nomesCopiados = new string[nomes.Length];
			nomes.CopyTo(nomesCopiados, 0);
			foreach(string nome in nomes)
			{
				System.Console.WriteLine(nome);
			}
		}
	}
	// Basicao
	class Pessoa
	{
		public string nome {get;set;}
		
		public Pessoa() : this("Abelardo Vieira Mota esta decepcionado porque c# nao possui default param")
		{
		}
		
		public Pessoa(string nome)
		{
			this.nome = nome;
		}
	}
	
	class Bola
	{
		public double raio;
		public Pessoa dono;
		
		public string NomeDoMeuDonoUpperCamelCaseUmaBosoca()
		{
			if(dono == null || dono.nome == null)
			{
				return null;
			}
			return dono.nome;
		}
		// Overload - sera que tem parametro default pela mor de zeus?!
		public string NomeDoMeuDonoUpperCamelCaseUmaBosoca(string ad)
		{
			return ad+this.NomeDoMeuDonoUpperCamelCaseUmaBosoca();
		}
	}
}
