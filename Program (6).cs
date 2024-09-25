

//ACTIVIDAD 40
//PROBLEMA 1
var miArray = new int[] { 5, 3, 1 };
Console.WriteLine("¿Qué elemento del array quieres cojer?");
var indice = Convert.ToInt32(Console.ReadLine());
try
{
	Console.WriteLine(miArray[indice]);
}
catch (IndexOutOfRangeException e)
{
	Console.WriteLine(e.Message);
}

//PROBLEMA 2
Console.WriteLine("Dame un número: ");
var numeroString = Console.ReadLine();

try
{
	var numeroEntero = Convert.ToInt32(numeroString);
	Console.WriteLine("El número ha sido convertido");
}
catch (FormatException e)
{
	Console.WriteLine(e.Message);
}

//PROBLEMA 3
var divisor1 = 5;
var divisor2 = 0;

try
{
	Console.WriteLine(divisor1 / divisor2);
}
catch (DivideByZeroException)
{
	Console.WriteLine("ERROR: Se ha intentado dividir entre cero");
}

