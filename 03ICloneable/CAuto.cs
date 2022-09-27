namespace icloneable;

public class CAuto : IAutomovil, ICloneable
{

  private double costo;
  private double tenencia;
  private string modelo;

  //constructuro
  public CAuto(string pModelo, double pCosto)
  {
    //inicializamos los datos
    costo = pCosto;
    modelo = pModelo;
  }

  //PROPERTIES
  public double Costo { get => costo; set => costo = value; }
  public double Tenencia { get => tenencia; set => tenencia = value; }

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
    Console.WriteLine("Costo {0}, con una Tenencia de {1}", costo, tenencia);
    Console.WriteLine("Total {0}", costo + tenencia);
    Console.WriteLine("----------------");
  }
  //IMPLEMENTACION DE LA INTERFAZ, METODO CLONE
  public object Clone()
  {
    //EN EL INTERIRO SE CREA UNA NUEVA INSTANCIA DE LA CLASE, YA QUE ESTA NUEVA INSTANCIA ES LA QUE SE MANDARA AL EXTERIRO CON LA COPIA DEL ESTADO DEL OBJETO, MANDANDO LOS ATRIBUNOS QUE TENEMOS EN ESTE CASO TEMP
    CAuto temp = new CAuto(modelo, costo);
    temp.tenencia = tenencia;
    return temp;
  }

}