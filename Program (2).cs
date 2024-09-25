// PRIMER PROBLEMA
Console.WriteLine("Introduce tu primer nombre y primer apellido separados por un espacio");
var nombreApelido = Console.ReadLine();
var posicionEspacio = nombreApelido.IndexOf(" ");

// SEGUNDO PROBLEMA
// PRIMERA VERSIÓN:
//var nombre = nombreApelido.Substring(0,posicionEspacio);
//Console.WriteLine("Tu nombre es: " + nombre);
//var apellido = nombreApelido.Substring(posicionEspacio + 1, nombreApelido.Length - posicionEspacio - 1);
//Console.WriteLine("Tu apellido es: " + apellido);
// SEGUNDA VERSIÓN
var nombreApellidoSeparado = nombreApelido.Split(" ");
var nombre = nombreApellidoSeparado[0];
var apellidos = nombreApellidoSeparado[1];
Console.WriteLine("Tu nombre es: " + nombre);
Console.WriteLine("Tu nombre es: " + apellidos);

// TERCER PROBLEMA:
Console.WriteLine("Tu nombre es: " + nombre.ToUpper());
Console.WriteLine("Tu nombre es: " + apellidos.ToUpper());

// CUARTO PROBLEMA
var texto = "Casa de papel";
// var textoLargo = "Somos un negocio familiar que sirve excelentes bebidas y comida. Hemos estado haciendo esto por más de 25 años. Nos enorgullecemos de ser un bar familiar y los gerentes de nuestros bares son todas mujeres de diferentes generaciones. Nos gusta ofrecer diferentes tipos de bebidas y alimentos que nuestros clientes puedan disfrutar. Disponemos de una gran selección de vinos y cervezas en nuestra barra, así como de todos nuestros tés, cafés y cafés.";

int ContarEspacios(string cadena)
{
    return cadena.Count(Char.IsWhiteSpace);
}
Console.WriteLine(ContarEspacios(texto));

// QUINTO PROBLEMA 
int ContarCoincidenciasDe(string texto)
{
    var separaciones = texto.Split(" de ");
    return separaciones.Length - 1;
}
Console.WriteLine("Apariciones 'de':" + ContarCoincidenciasDe(texto));
