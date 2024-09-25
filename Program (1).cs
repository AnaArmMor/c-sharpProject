// PROBLEMA 1
Console.WriteLine("PROBLEMA 1");
for (int i = 0; i < 100; i++)
{
	if (i == 49)
	{
        Console.ForegroundColor = ConsoleColor.Red;
    }
	else
	{
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine(i);
}

// PROBLEMA 2
Console.WriteLine("PROBLEMA 2");
double[] notas = new double[] { 8.5, 3, 2, 1.3 };
void CalcularMedia(double[] notasAlumnos)
{
	// Calculamos la nota meida
    double sumaNotas = 0;
	for (int i = 0; i <= notas.Length; i++)
	{
		sumaNotas += notasAlumnos[i];
	}
	double notaMedia = sumaNotas / notasAlumnos.Length;

	// Comprobamos su valor y la mostramos por pantalla en el color correspondiente
	if (notaMedia < 5)
	{
		Console.ForegroundColor = ConsoleColor.Red;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Green;
	}
    Console.WriteLine(notaMedia);
}

CalcularMedia(notas);