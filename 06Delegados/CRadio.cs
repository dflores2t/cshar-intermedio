namespace delegados;

public class CRadio{
  //este metodo actuara como delegado

  public static void MetodoRadio(string pMensaje){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("ESTAMOS EN LA CLASE RADIO");
    Console.WriteLine("ESTE ES TU MENSAJE {0}",pMensaje);
    
  }
}