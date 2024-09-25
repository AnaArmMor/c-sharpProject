// PROBLEMA 1
Console.WriteLine("PROBLEMA 1");
int operando1 = 3;
int operando2 = 3;
Console.WriteLine(operando1 + "x" + operando2 + "=" + operando1 * operando2);

// PROBLEMA 1b
Console.WriteLine("Dame el primer operando:");
string operando1b = Console.ReadLine();
Console.WriteLine("Dame el segundo operando:");


// PROBLEMA 2
Console.WriteLine("PROBLEMA 2");
int operando1_problema2 = 3;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(operando1_problema2 + "x" + i + "=" + operando1_problema2 * i);
}

// PROBLEMA 3
Console.WriteLine("PROBLEMA 3");
int[] miArray = new int[3] { 1, 2, 3 };
int RealizarPoducto(int operando1, int operando2)
{
    return operando1 * operando2;
}
Console.WriteLine(RealizarPoducto(2,5));

// PROBLEMA 4
Console.WriteLine("PROBLEMA 4");
int[] arrayPrueba = new int[] { 0, 1, 2 };
int[] IncrementarElementosArray(int[] array)
{
    int[] arrayVacio = new int[3];
    for (int i = 0; i < miArray.Length; i++)
    {
        arrayVacio[i] = array[i] + 1;
    }
    return arrayVacio;
}
// LLamo a la función que he creado, mostrando el resultado por pantalla
foreach (var numero in IncrementarElementosArray(arrayPrueba))
{
    Console.WriteLine(numero);
}

// PROBLEMA 5
Console.WriteLine("PROBLEMA 5");
int[] ProductoEnteroyArray(int entero, int[] array)
{
    // Creo un array vacío
    int[] arrayVacio = new int[3];
    // Recorro el array que recibo por paramtro 
    for (int i = 0; i < array.Length; i++)
    {
        arrayVacio[i] = entero * array[i];
    }
    return arrayVacio;
}
// LLamo a la función que he creado, mostrando el resultado por pantalla
foreach (var numero in ProductoEnteroyArray(3, arrayPrueba))
{
    Console.WriteLine(numero);
}

