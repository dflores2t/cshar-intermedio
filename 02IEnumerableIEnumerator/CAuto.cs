namespace ienumerableienumerator;

public class CAuto : IAutomovil
{

  double costo;
  double tenencia;
  string modelo;

  //constructuro
  public CAuto(string pModelo, double pCosto)
  {
    //inicializamos los datos
    costo = pCosto;
    modelo = pModelo;
  }

  //METODOS DE LA INTERFAZ
  public void CalculaTenencia(double pImpuesto)
  {
    //CALCULAMOS EL IMPUESTO
    tenencia = 5000.0 + costo * pImpuesto;
  }

  public void MuestraInformacion()
  {
    //MOSTRAMOS LA INFORMACION NECESARIA
    Console.WriteLine("TU AUTOMOVIL {0}", modelo);
    Console.WriteLine("Costo {0}, con una Tenencia de {1}", costo,tenencia);
    Console.WriteLine("Total {0}", costo + tenencia);
    Console.WriteLine("----------------");
  }

}