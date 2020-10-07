using System;

namespace Convertissor00
{
	class Program
	{
		public static void Main(string[] args)
		{
			//double montant = ConvertToEurFromDollar(9.99);
			//Console.WriteLine(montant);
			double[] montants = {9.99,35000,239000};
			for(int i = 0; i < montants.Length; i++){
				Console.WriteLine(ConvertToEurFromDollar(montants[i]));
				Console.WriteLine(ConvertToDollarFromEuro(montants[i]));
			}
			Console.WriteLine(ConvertToCelsius(122));
			Console.WriteLine(ConvertToFahrenheit(25));
			
			int[] r = Trier(9,8,7);
			for(int i = 0; i < r.Length; i++){
				Console.Write(r[i] + " ");
			}
			Console.ReadKey(true);
		}
		
		public static double ConvertToEurFromDollar(double d){
			return d * 0.8;
		}
		
		public static double ConvertToDollarFromEuro(double d){
			return d*1.2;
		}
		
		public static double ConvertToFahrenheit(double celsius){
			return (celsius-32)/1.8;
		}
		public static double ConvertToCelsius(double fahrenheit){
			return (fahrenheit*1.8)+32;
		}
		public static void AfficherDonneesRectangle(int a, int b){
			Console.WriteLine(CalculPerimetre(a,b));
			Console.WriteLine(CalculSurface(a,b));
			Console.WriteLine(CalculDiagonale(a,b));
		}
		public static int CalculPerimetre(int a, int b){
			return 2*(a+b);
		}
		public static int CalculSurface(int a, int b){
			return a*b;
		}
		public static double CalculDiagonale(int a, int b){
			return Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
		}
		public static void AfficherDonneesCarre(int a){
			Console.WriteLine(CalculPerimetre(a,a));
			Console.WriteLine(CalculSurface(a,a));
			Console.WriteLine(CalculDiagonale(a,a));
		}
		public static int[] Trier(int a, int b, int c){
			int[] result = {a,b,c,4,1};
			// presenceChangement doit etre true pour executer la boucle au moins une fois
			bool presenceChangement = true;
			while(presenceChangement){ // while(presenceChangement == true)
				presenceChangement = false;// reset 
				for(int i = 0; i < result.Length-1;i++){
					// C'est dans le if que les "switch" se font
					if(result[i] > result[i+1]){
						// switch des deux valeurs						
						int temp = result[i];
						result[i] = result[i+1];					
						result[i+1] = temp;
						presenceChangement = true;
					}
				}
			}
			return result;
		}
		public static int[] TrierDesc(int a, int b, int c){
			int[] result = {a,b,c,4,1};
			
			return result;
		}
		public static int[] Trier(int a, int b, int c, char type){
			if(type == 'a'){
				return Trier(a, b, c);
			}else{
				return TrierDesc(a,b,c);
			}
		}
//		public static ??? test(int[] result){
//			if(a > b){
//				int temp = a;
//				result[0] = b;
//				result[1] = temp;
//			}
//		}
	}
}