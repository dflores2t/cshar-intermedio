namespace delegados;

public class CTienda{
  public static void MandaViveres(int pKilos){
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---> Vamos a mandar sus viveres, estoy en la tienda");
    Console.WriteLine("---> Seran {0} kilos", pKilos);
  }
}