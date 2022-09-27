namespace serializacionXml;

using System.Xml.Serialization;
using System.IO;

public class Program{
  static void Main(string[] args){
    int opcion = 0;
    string? valor = "";

    Console.WriteLine("1) CREAR Y SERIALIZAR AUTO, 2) LEER AUTO");
    valor = Console.ReadLine();
    opcion = Convert.ToInt32(valor);

    if (opcion == 1)
    {
      //creamos el objeto cauto
      string? modelo = "";
      double costo = 0.0;

      Console.WriteLine("DAME EL MODELO");
      modelo = Console.ReadLine();

      Console.WriteLine("DAME EL COSTO");
      valor = Console.ReadLine();
      costo = Convert.ToDouble(valor);

      CAuto miAuto = new CAuto();
      miAuto.Modelo = modelo;
      miAuto.Costo = costo;
      Console.WriteLine("AUTO A SERIALIZAR");
      miAuto.MuestraInformacion();
      //EMPEZAMOS LA SERIALIZACION
      Console.WriteLine("----SERIALIZAMOS---");
      //SELECCIONAMOS EL FORMATEADOR
      XmlSerializer formatter = new XmlSerializer(typeof(CAuto));
      // SoapFormatter formatter = new SoapFormatter(); //esta referencia no es compatile con netcore actualmente.
      //SE CREA EL STREAM
      Stream miStream = new FileStream("/home/dail/dotNet5/csharp-intermedio/12SerializacionXml/Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);
      //SERIALIZAMOS
      formatter.Serialize(miStream, miAuto);
      //CERRAMOS EL STREAM
      miStream.Close();
    }
    if (opcion == 2)
    {
      //DESERIALIZAMOS EL OBJETO
      Console.WriteLine("-----DESEREALIZAMOS------");
      //SELECCIONAMOS EL FRMATEADOR
      //SoapFormatter formatter = new SoapFormatter(); no compatile con netcore.
      XmlSerializer formatter = new XmlSerializer(typeof(CAuto));

      //CREAMOS EL STREAM
      Stream miStrema = new FileStream("/home/dail/dotNet5/csharp-intermedio/12SerializacionXml/Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
      //DESEREALIZACION
      CAuto miAuto = (CAuto)formatter.Deserialize(miStrema);

      //CERRAMOS EL STREAM
      miStrema.Close();
      //USAMOS EL OBJETO
      Console.WriteLine("EL AUTO DESEARIZADO ES : ");
      miAuto.MuestraInformacion();
    }
  }
}