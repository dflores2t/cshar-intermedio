namespace streams
{
  public class Program {
    static void Main(string[] args){
        //STREAM ES UNA SECUANCIA DE DATOS, BITE O BYTE Y NOS PODEMOS MOVER DENTRO DE ESE STREAM COMO EN UNA CINTA.

      Console.WriteLine("HOLA");
      long cantidad = 0;
      long n = 0;
      int valor = 0;

      FileStream fs = new FileStream("/home/dail/dotNet5/csharp-intermedio/15StreamsFlujos/datos.txt", FileMode.Open,FileAccess.Read, FileShare.None);
      //obtenemos la cantidad
      cantidad = fs.Length;
      Console.WriteLine("EL ARCHIVO MIDE {0} BYTES", cantidad);

      //leemos byte por bye
      for (n = 0; n < cantidad ; n++){
        //ponemos la posicion
        fs.Seek(n, SeekOrigin.Begin);
        valor = fs.ReadByte();
        Console.Write("{0}", (char)valor);
      }
      Console.WriteLine("\n--------------------------------------\n");

      //LEEMO AHORA EN OTRO SENTIDO.

      for (n = 1; n <= cantidad; n++){
        //ponemos la posicion
        fs.Seek(-n, SeekOrigin.End);
        valor = fs.ReadByte();
        Console.Write("{0}", (char)valor);
      }
      Console.WriteLine("\n-----------------------------\n");

      fs.Seek(0, SeekOrigin.Begin);
      //leer sin conocer la longitud
      while((valor = fs.ReadByte())> 0){
        Console.Write("{0}",(char)valor);
      }

      Console.WriteLine("\n----------------\n");



      fs.Close();
    }
  }
  
}