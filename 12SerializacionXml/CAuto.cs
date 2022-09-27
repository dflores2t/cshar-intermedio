namespace serializacionXml;


[Serializable] 
public class CAuto
{
  private double costo;
  private string modelo;
  //constructur si parametros cuando es xml
  public CAuto()
  {
    //inicializamos los datos
    costo = 100000;
    modelo = "VOCHO";
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