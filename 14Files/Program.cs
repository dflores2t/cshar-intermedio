using System;
using System.IO;
namespace archivos
{
  public class Program
  {
    static void Main(string[] args)
    {
      //DECIDIR QUE VALORES SE ESTARAN ESCRIBIENDO. NO ES SERIALIZACION ES TOTALMENTE DIFIERNTE
      int opcion = 0;
      string? valor = "";

      Console.WriteLine("1)CREAR ARCHIVO, 2) LEER ARHIVO");
      valor = Console.ReadLine();
      opcion = Convert.ToInt32(valor);
      if (opcion == 1)
      {
        //creamos el objeto cauto
        string? modelo = "";
        double costo = 0;
        Console.WriteLine("DAME EL MODELO");
        modelo = Console.ReadLine();
        Console.WriteLine("DAME EL COSTO");
        costo = Convert.ToDouble(Console.ReadLine());

        CAuto miAuto = new CAuto(modelo, costo);

        //variables extra
        int numero = 5;
        bool acceso = false;
        byte conteo = 120;

        //creamos el stream
        FileStream fs = new FileStream("/home/dail/dotNet5/csharp-intermedio/14Files/MiArchivo.txt", FileMode.Create, FileAccess.Write, FileShare.None);

        //creamos el escritor
        BinaryWriter writer = new BinaryWriter(fs);

        //ESCRIBIMOS LOS ATRIBUTOS
        //OJO, NO ES SERIALIZACION
        writer.Write(miAuto.Modelo);
        writer.Write(miAuto.Costo);

        //ESCRIBIMOS LAS VARIABLES
        writer.Write(numero);
        writer.Write(acceso);
        writer.Write(conteo);

        //cerramos el stream
        fs.Close();
      }
     if(opcion ==2){
        //HESERIALIZAMOS EL OBJETO
        Console.WriteLine("------LEEMOS ACHIVO-------");
        //creamos el stream
        Stream fs = new FileStream("/home/dail/dotNet5/csharp-intermedio/14Files/MiArchivo.txt",FileMode.Open, FileAccess.Read,FileShare.None);

        //creamos el lector
        BinaryReader lector = new BinaryReader(fs);

        //LEEMOS EN EL MISMO ORDEN QUE SE ESCRIBIO
        //TOMANDO EN CUENTA EL TIPO
        string modelo = "";
        double costo = 0;
        int numero = 0;
        bool acceso = true;
        byte conteo = 0;

        modelo = lector.ReadString();
        costo = lector.ReadDouble();
        CAuto miAuto = new CAuto(modelo, costo);

        numero = lector.ReadInt32();
        acceso = lector.ReadBoolean();
        conteo = lector.ReadByte();

        //cerramos stream
        fs.Close();

        //MOSTRAMOS DATOS
        miAuto.MuestraInformacion();
        Console.WriteLine("numero {0}", numero);
        Console.WriteLine("acceso {0}", acceso);
        Console.WriteLine("conteo {0}", conteo);
      }
    }
  }
}