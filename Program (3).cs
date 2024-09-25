using MiCalculadora.Clases;


// PROBLEMA 5
while (true)
{
    Console.WriteLine("¿Qué operacion quieres hacer? (1)Sumar (2)Restar (3)Multiplicar (4)Dividir. Pulsa 0 para salir.");
    var opcion = Console.ReadLine();

    if (opcion == "0")
    {
        break;
    }

    Console.WriteLine("Dame el primer operando:");
    var primerOperando = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Dame el segundo operando:");
    var segundoOperando = Convert.ToDouble(Console.ReadLine());


    switch (opcion)
    {
        case "1":
            Console.WriteLine(Calculadora.Sumar(primerOperando, segundoOperando));
            break;
        case "2":
            Console.WriteLine(Calculadora.Restar(primerOperando, segundoOperando));
            break;
        case "3":
            Console.WriteLine(Calculadora.Multiplicar(primerOperando, segundoOperando));
            break;
        case "4":
            Console.WriteLine(Calculadora.Dividir(primerOperando, segundoOperando));
            break;
        default:
            break;
    }
}


// PROBLEMA 6
/*
 * Aquí se está aplicando el concepto de la sobrecarga. .NET sabe a qué método llamar evaluando el número de prámetros y su tipo.
*/

