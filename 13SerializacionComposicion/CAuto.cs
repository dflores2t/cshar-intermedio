namespace serializacionComposicion;


[Serializable] 
public class CAuto
{
  private double costo;
  private string modelo;
  private CMotor motor;


  //constructur si parametros cuando es xml
  public CAuto()
  {
    //inicializamos los datos
    costo = 100000;
    modelo = "VOCHO";
    motor = new CMotor();
  }
  public CAuto(string pModelo, double pCosto, int pCilindros, int pHP)
  {
    modelo = pModelo;
    costo = pCosto;
    motor = new CMotor(pCilindros, pHP);
  }

  public double Costo { get=> costo; set=> costo = value; }
  public string Modelo { get=> modelo; set=> modelo = value; }
  public CMotor Motor { get=> motor; set=> motor =value; }

  public void MuestraInformacion()
  {
    //MOSTRAMOS LA INFORMACION NECESARIA
    Console.WriteLine("TU AUTOMOVIL {0}", modelo);
    Console.WriteLine("Costo {0}", costo);
    motor.Muestra();
    Console.WriteLine("----------------");
  }

}