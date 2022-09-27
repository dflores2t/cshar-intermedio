namespace delegados;
public class Program
{
  //DEFINIMOS EL DELEGADO CON LAS CARACTERISTICAS QUE NOS INTERESA
  public delegate void MiDelagado(string m);
  static void Main(string[] args)
  {
    //CREAMOS UN OBJETO DEL DELEGADO Y LO REFERENCIAMOS A UN METODO
    MiDelagado delegado = new MiDelagado(CRadio.MetodoRadio);

    //AHORA POR MEDIO DEL DELEGADO HACEMOS USO DEL METODO
    delegado("HOLA A TODOS");

    //HACEMOS QUE APUNTE A OTRO METODO
    delegado = new MiDelagado(CPastel.MostrarPastel);
    //AHORA INVOCAMOS EL OTRO METODO
    delegado("FELIZ CUMPLEANOS");


    //SEGUNDA PARTE
    //creamos refri
    Crefri miRefri = new Crefri(70, -20);
    Random rnd = new Random();

    //adicionamol los handlers
    // miRefri.AdicionaMetodoReservas(new Crefri.DReservasBajas(InformeKilos));
    // miRefri.AdicionaMetodoDescongelado(new Crefri.DDescongelado(InformeGrados));
    //mi refri trabaja
    // while(miRefri.Kilos > 0){
    //   miRefri.Trabajar(rnd.Next(1, 5));
    // }

    //TERCERA PARTE
    DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
    DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

    DDescongelado desc1 = new DDescongelado(InformeGrados);

    //ADICIONAMOS LOS HANDLERS
    miRefri.AdicionaMetodoReservas(kilos1);
    miRefri.AdicionaMetodoReservas(kilos2);
    miRefri.AdicionaMetodoDescongelado(desc1);

    //el refri trabaja=
    while(miRefri.Kilos > 0){
      miRefri.Trabajar(rnd.Next(1, 5));
    }

    //Eliminamos un handler
    miRefri.EliminaMetodoReservas(kilos2);
    

    //rellenamo el refri
    miRefri.Kilos = 50;
    miRefri.Grados = -15;

    while(miRefri.Kilos > 0){
      miRefri.Trabajar(rnd.Next(1, 5));
    }

  }

  public static void InformeKilos(int pKilos){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---> RESERVAS BAJAS DE ALIMENTOS, ESTOY A NIVEL DE MAIN");
    Console.WriteLine("---> QUEDAN {0} KILOS",pKilos);
  }

  public static void InformeGrados(int pGrados){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("---> SE DESCONGELA EL REFRI, ESTOY A NIVEL DE MAIN");
    Console.WriteLine("---> ESTA A {0} GRADOS", pGrados);
  }


}