//PROBLEMA 1
var miMatriz = new int[,] { { 5, 8, 9, 2 }, { 3, 4, 1, 2 }, { 2, 2, 2, 2 } };
for (int fila = 0; fila < miMatriz.GetLength(0); fila++)
{
    switch (fila)
    {
        case 0:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
    for (int col = 0; col < miMatriz.GetLength(1); col++)
    {
        Console.Write(miMatriz[fila, col]);
        if (col < miMatriz.GetLength(1) - 1)
            Console.Write("-");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.White;

// PROBLEMA 2
//var miMatriz = new int[,] { { 5, 8, 9, 2 }, { 3, 4, 1, 2 }, { 2, 2, 2, 2 } };
//var suma = 0;
//for (int fila = 0; fila < miMatriz.GetLength(0); fila++)
//{
//    for (int columna = 0; columna < miMatriz.GetLength(1); columna++)
//    {
//        suma = suma + miMatriz[fila, columna];
//    }
//    Console.WriteLine();
//    Console.WriteLine($"Los elementos de la fila {fila} dan como media: {Convert.ToDouble(suma) / (miMatriz.GetLength(0) + 1)}");
//    suma = 0;
//}
//Console.ForegroundColor = ConsoleColor.White;
