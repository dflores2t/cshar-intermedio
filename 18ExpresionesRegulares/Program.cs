using System.Text.RegularExpressions;

namespace expresioneRegulares;

public class Program {
  static void Main(string[] args){
    //METODO 1

    //son utilizadas para encontrar una subcadena dentro de un texto mucho mas grande, una expresion que represente algo que se desea buscar
    string texto = "la casa del casamentero";
    string exp = "casa";

    MatchCollection encontrado = Regex.Matches(texto, exp);

    foreach (Match e in encontrado)
    {
      Console.WriteLine(e);
    }
    Console.WriteLine("--------------------------------------------------------");
    //METODO 2

    Console.WriteLine("------------metodo 2 ---------------");
    //busqueda de una palabra especifica (ojo si esta al final)
    texto = "el estudiante es un casa nova en la escuela";
    exp = " casa "; //espacio casa espacio, se debe cumplir la regla

    Regex expReg = new Regex(exp);
    encontrado = expReg.Matches(texto);

    foreach (Match e in encontrado)
    {
      Console.WriteLine(e);
    }

    Console.WriteLine("-------------------------------------------");
    //
    Console.WriteLine("------uso del . cualquier caracter----------------");
    //. significa cualquier caracter
    //cabal, campeon, academico
    texto = "Saludos al mas academico";
    exp = " ca.";
    MatchesExp(texto, exp);

    Console.WriteLine("-----------------------");
    Console.WriteLine("clases de caracteres se usa [] para conener los caracteres");
    texto = "Hola Nico";
    exp = "N[ie]c"; //algo que empiece con N mayuscula luego puede tener ie y C
    MatchesExp(texto, exp);

    //SEGUNDA PARTE
    //USO DE RANGOS
    Console.WriteLine("USO DE RANGOS");
    texto = "Hola Nuco";
    exp = "N[a-u]c"; //el rango es desde a hasta u
    MatchesExp(texto, exp);

    Console.WriteLine("USO DE COMPLEMENTO");
    //TODO AQUELLO QUE NO FORMA PARTE DE DETERMINADOS CARACTERES
    texto = "Hola Noco";
    exp = "N[^ie]c"; //negacion, que no tenga ie
    MatchesExp(texto, exp);

    Console.WriteLine("VERIFIGCAMOS SI TIENE LA EXPRESION DESPUES DE N CARACTERES");
    texto = "De Youtebe Nicosiored es mi canal favorito";
    exp = "N[ie]c";
    expReg = new Regex(exp);
    Console.WriteLine(expReg.IsMatch(texto, 5) ? "SI TIENE" : "NO TIENE");

    //
    Console.WriteLine("PARA SABOR SI UNA CADENA FINALIZA CON UNA DETERMINADA EXPRESIO");
    texto = "De Youtebe Nicosiored es mi canal favorito Nic";
    exp = "N[ie]c$"; //la exp tiene que ser buscada hasta el final.
    MatchesExp(texto, exp);

    Console.WriteLine("ELEMENTOS OPCIONALES");
    texto = "Hola Nico";
    exp = "N[ie]c?o"; //elementos opcionales ? la c es un elemento opcional puede o no existir y luego la o
    MatchesExp(texto, exp);

    Console.WriteLine("CUANTIFICADOR");
    // busca que existan n de esos elementos
    texto = "Holaa 25 Nico";
    exp = "[0-9]{2}"; //aparecen caracteres de 0-0 2 veces.
    MatchesExp(texto, exp);

    //alternaciones entre parentesiso y or, los elemenos que posibilemene pueden estar en el texto
    Console.WriteLine("ALTERNACIONES");
    texto = "Yo se programar en c";
    exp = "(c|java|python)";
    MatchesExp(texto, exp);

    Console.WriteLine("SPLIT");
    //corta el texto y saca usa subcadena de acuerdo al exp regualer
    texto = "Este es un tes de separacion, division";
    exp = ",";
    string[] cadenas = Regex.Split(texto, exp);
    foreach(string c in cadenas)
      Console.WriteLine(c);
    
    Console.WriteLine("REEMPLAZAR");
    texto = "Yo hablo ingel y no soy ingles";
    expReg = new Regex("ingles");
    string reemplazo = "Español";
    string resultado = expReg.Replace(texto, reemplazo);
    Console.WriteLine(resultado);
    Console.WriteLine("----------------------------");




  }

  public static void MatchesExp(string pTexto, string pExp){
    MatchCollection encontrado = Regex.Matches(pTexto, pExp);
    foreach(Match e in encontrado){
      Console.WriteLine(e);
    }
    Console.WriteLine("-------------------------------");
  }
}