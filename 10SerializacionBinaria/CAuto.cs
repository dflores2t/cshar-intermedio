namespace SerializacionBinaria;


[Serializable]  //esto indica que las instancias se pueden almacenar en el hdd o en otro medio
public class CAuto
{
  double costo;
  string modelo;
  //constructuro
  public CAuto(string pModelo, double pCosto)
  {
    //inicializamos los datos
    costo = pCosto;
    modelo = pModelo;
  }

  public void MuestraInformacion()
  {
    //MOSTRAMOS LA INFORMACION NECESARIA
    Console.WriteLine("TU AUTOMOVIL {0}", modelo);
    Console.WriteLine("Costo {0}", costo);
    Console.WriteLine("----------------");
  }

}