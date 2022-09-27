namespace indexer;

public class CAuto{
  double costo;
  double tenencia;
  string modelo;

  public CAuto(string pModelo, double pCosto)
  {
    //inicializamo los datos
    costo = pCosto;
    modelo = pModelo;
  }
  public void MuestraInformacion(){
    //MOSTRAMOS LA INFORMACION NECESARIA
    Console.WriteLine("TU AUTOMOVIL :{0}", modelo);
    Console.WriteLine("COSTO {0}", costo);
    Console.WriteLine("-------------------");
  }


}