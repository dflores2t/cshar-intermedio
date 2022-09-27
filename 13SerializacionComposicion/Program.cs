using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace serializacionComposicion;



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
      int cilindros = 0;
      int hp = 0;

      Console.WriteLine("DAME EL MODELO");
      modelo = Console.ReadLine();

      Console.WriteLine("DAME EL COSTO");
      valor = Console.ReadLine();
      costo = Convert.ToDouble(valor);
      Console.WriteLine("DAME EL CILINDROS");
      valor = Console.ReadLine();
      cilindros = Convert.ToInt32(valor);
      Console.WriteLine("DAME LOS HP");
      valor = Console.ReadLine();
      hp = Convert.ToInt32(valor);

      // CAuto miAuto = new CAuto();
      CAuto miAuto = new CAuto(modelo,costo,cilindros,hp);
      // CMotor miMotor = new CMotor();

      // miMotor.Cilindros = cilindros;
      // miMotor.HP = hp;

      // miAuto.Modelo = modelo;
      // miAuto.Costo = costo;
      // miAuto.Motor = miMotor;

      Console.WriteLine("AUTO A SERIALIZAR");
      miAuto.MuestraInformacion();
      //EMPEZAMOS LA SERIALIZACION
      Console.WriteLine("----SERIALIZAMOS---");
      //SELECCIONAMOS EL FORMATEADOR
      // BinaryFormatter formatter = new BinaryFormatter();
      XmlSerializer formatter = new XmlSerializer(typeof(CAuto), new Type[] {typeof(CMotor)});
      // SoapFormatter formatter = new SoapFormatter(); //esta referencia no es compatile con netcore actualmente.
      //SE CREA EL STREAM
      Stream miStream = new FileStream("/home/dail/dotNet5/csharp-intermedio/13SerializacionComposicion/Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);
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
      // BinaryFormatter formatter = new BinaryFormatter();
      XmlSerializer formatter = new XmlSerializer(typeof(CAuto), new Type[] { typeof(CMotor) });

      //CREAMOS EL STREAM
      Stream miStrema = new FileStream("/home/dail/dotNet5/csharp-intermedio/13SerializacionComposicion/Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
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