namespace archivos;

[Serializable] 
public class CAuto
{
  private double costo;
  private string modelo;

  public CAuto(string pModelo, double pCosto)
  {
    modelo = pModelo;
    costo = pCosto;
  }

  public double Costo { get=> costo; set=> costo = value; }
  public string Modelo { get=> modelo; set=> modelo = value; }

  public void MuestraInformacion()
  {
    //MOSTRAMOS LA INFORMACION NECESARIA
    Console.WriteLine("TU AUTOMOVIL {0}", modelo);
    Console.WriteLine("Costo {0}", costo);
    Console.WriteLine("----------------");
  }

}