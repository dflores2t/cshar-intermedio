namespace delegados;

public class CPastel{
  //Este metodo actuara como delegado

  public static void MostrarPastel(string pAnuncio){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("EL PASTEL LLEVARA EL MENSAJE {0}",pAnuncio);
  }
}