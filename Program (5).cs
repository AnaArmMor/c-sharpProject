// PROBLEMA 1
//Console.WriteLine("Dame un primer número entero");
//var primerNumero = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Dame un segundo número entero");
//var segundoNumero = Convert.ToInt32(Console.ReadLine());
//var random = new Random();
//var numeroAleatorio = random.Next(primerNumero, segundoNumero + 1);
//Console.WriteLine($"Tu número aleatorio entre {primerNumero} y {segundoNumero} es {numeroAleatorio}");

// PROBLEMA 2
//Console.WriteLine("Dame un primer número entero");
//var primerNumero = Convert.ToInt32(Console.ReadLine());
//int segundoNumero;
//do
//{
//	Console.WriteLine("Dame un segundo número entero");
//	segundoNumero = Convert.ToInt32(Console.ReadLine());
//	if (segundoNumero < primerNumero)
//	{
//		Console.WriteLine("El segundo número ha de ser mayor al primero.");
//	}
//} while (segundoNumero < primerNumero);
//var random = new Random();
//var numeroAleatorio = random.Next(primerNumero, segundoNumero + 1);
//Console.WriteLine($"Tu número aleatorio entre {primerNumero} y {segundoNumero} es {numeroAleatorio}");

// PROBLEMA 3
//var arrayNumeros = new string[] {"UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS"};
//Console.WriteLine("¿Con cuántos dados quieres jugar?:");
//var numeroDeDados = Convert.ToInt32(Console.ReadLine());
//var random = new Random();
//int resultadoTiradaDado;

//for (int i = 0; i < numeroDeDados; i++)
//{
//    resultadoTiradaDado = random.Next(1, 7);
//    Console.WriteLine($"Resultado del dado número {i + 1}: {arrayNumeros[resultadoTiradaDado - 1]}");
//}

// PROBLEMA 4
Console.WriteLine("Problema 4");

Console.WriteLine("Usuario A elige un numero de 0 a 100? ");
int numUsuarioA = int.Parse(Console.ReadLine());

Console.WriteLine("Usuario B elige un numero de 0 a 100? ");
int numUsuarioB = int.Parse(Console.ReadLine());

Random num = new Random();
int numeroAle = num.Next(0, 101);
Console.WriteLine("El numero aleatorio es: " + numeroAle);


if (numUsuarioA < numeroAle || numUsuarioB < numeroAle)
{
    int a = numeroAle - numUsuarioA;
    int b = numeroAle - numUsuarioB;

    if (a > b)
    {
        Console.WriteLine("Ganador es B");
    }
    else if (a < b)
    {
        Console.WriteLine("Ganador es A");

    }
    else
    {
        Console.WriteLine("Empate");
    }
}
else
{
    int a = numUsuarioA - numeroAle;
    int b = numUsuarioB - numeroAle;

    if (a > b)
    {
        Console.WriteLine("Ganador es B");
    }
    else if (a < b)
    {
        Console.WriteLine("Ganador es A");

    }
    else
    {
        Console.WriteLine("Empate");
    }


}
