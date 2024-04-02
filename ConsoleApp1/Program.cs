using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("CONVERSOR DE UM BINÁRIO DE 4 BITS\n");
		List<int> Bin = new List<int>();
		for (int i = 0; i < 4; i++)
		{
			Console.Write($"Informe o {i + 1}º bit: ");
			Bin.Add(int.Parse(Console.ReadLine()));
		}

		String Temp = String.Join("", Bin);
		int Decimal = Convert.ToInt32(Temp, 2);
		string Octal = Convert.ToString(Decimal, 8);
		string Hexa = Convert.ToString(Decimal, 16).ToUpper();
		Console.WriteLine("\nBinário informado: " + Temp);
		Console.WriteLine("Convertido para Decimal: " + Decimal);
		Console.WriteLine("Convertido para Octal: " + Octal);
		Console.WriteLine("Convertido para Hexa: " + Hexa);
		Console.WriteLine("\n A   B   C   D   AND   OR");
		Console.WriteLine($" {Bin[0]} | {Bin[1]} | {Bin[2]} | {Bin[3]}" + "    " + (Bin[0] & Bin[1] & Bin[2] & Bin[3]) + "    " + (Bin[0] | Bin[1] | Bin[2] | Bin[3]));
		Console.WriteLine("\nTABELA VERDADE");
		Console.WriteLine(" A   B   C   D     S = (A.B.C.D)   S = (C+D).(A.C)   S = (A+B+C+D)   S = (A+B)+(C.D)");
		int[] A = [0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1];
		int[] B = [0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1];
		int[] C = [0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1];
		int[] D = [0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1];
		for (int i = 0; i < A.Length; i++)
		{
			Console.WriteLine($" {A[i]} | {B[i]} | {C[i]} | {D[i]}" + 
			"            " + (A[i] & B[i] & C[i] & D[i]) + 
			"                " + ((C[i] | D[i]) & (A[i] & C[i])) + 
			"                " + (A[i] | B[i] | C[i] | D[i]) + 
			"                " + ((A[i] | B[i]) | (C[i] & D[i])));
		}
	}
}
