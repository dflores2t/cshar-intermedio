namespace callback;


public class CTiendaSink : IEventosRefri
{
  //aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento
  public void EReservasBajas(int pKilos)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-----> LE ENVIAREMOS SUS VIVERES ");
    Console.WriteLine("-----> SERAN {0} KILOS",pKilos);
  }

  public void EDescongelado(int pGrados){
    //handler vacio, -> no es recomendable.
  }
}