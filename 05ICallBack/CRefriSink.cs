namespace callback;

public class CRefriSink : IEventosRefri{

  private bool paro = false;
  public bool Paro { get => paro; }
  public void EDescongelado(int pGrados)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("-----> Refri se Descongela----");
    if(pGrados > 0){
      paro = true;
    }
  }

  // OBJETO QUE LLEVA ACABA LA ACCION CUANDO EL EVENTO SUCEDA
  //UN METODO QUE SE INVOCA CUANDO LA CONDICION DEL EVENTO SUCEDE.
  //ACA VAN LOS HANDLER DE LOS EVENTOS DEFINIDOS EN LA INTERFAZ

  public void EReservasBajas(int pKilos){
    //AQUI SE COLOCA TODO EL CODIGO NECESARIO PARA EJECUTAR CUANDO SUCEDA EL EVENTO
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---> RESERVAS AJAS DE ALIMENTOS");
    Console.WriteLine("---> Quedan {0} Kilos",pKilos);
  }
}