Triangulo.cs 

/*
Objetivo: calcular el área de un triangulo rectangulo 
programador: Carlos Lopez
Fecha: 17/09/19
*/
using System; 
class Triangulo
{
	public static void Main()
	{

		//constantes y variables

		const int Base=3;
		float Altura,Area;

		//entrada

		Console.Write("Teclee la Altura del Triangulo:");
		Altura= float.Parse(Console.ReadLine());

		//proceso

		Area=Base * Altura / 2.0; 

		//salida

		Console.WriteLine("Àrea del Triangulo: {0}",Area);
		
		//Pausa

		Console.ReadKey();
	}
}