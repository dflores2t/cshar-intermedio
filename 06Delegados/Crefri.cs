namespace delegados;
public delegate void DReservasBajas(int pKilos);
public delegate void DDescongelado(int pGrados);

public class Crefri{
  //aca van los delegados
  // public delegate void DReservasBajas(int pKilos);
  // public delegate void DDescongelado(int pGrados);

  private int kilosAlimentos = 0;
  private int grados = 0;

  //aqui estan las variables que usaremos para invocar
  private DReservasBajas? delReservas;
  private DDescongelado? delDescongelado;

  public Crefri(int pKilos, int pGrados){
    //colocamos los valores iniciales del refri
    kilosAlimentos = pKilos;
    grados = pGrados;
  }
  //estos metodos permiten referenciar las variable
  public void AdicionaMetodoReservas(DReservasBajas pMetodo){
    delReservas += pMetodo;
  }
  public void EliminaMetodoReservas(DReservasBajas pMetodo) => delReservas -= pMetodo;
  public void AdicionaMetodoDescongelado(DDescongelado pMetodo){
    delDescongelado += pMetodo;
  }

  //propiedades necesaria
  public int Kilos { get => kilosAlimentos; set => kilosAlimentos = value; }
  public int Grados { get => grados; set => grados = value; }

  public void Trabajar(int pConsumo)
  {
    //actualizamos los kilos del refri
    kilosAlimentos -= pConsumo;

    //subimos la temperatura;
    grados += 1;
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("{0} kilos , {1} grados",kilosAlimentos,grados);

    //hay que verificar si se cumple la condicon para invocar los handler del evento
    //esta condicion activa el evento kilos
    if(kilosAlimentos < 10){
      //invocamos el metodo
      delReservas(kilosAlimentos);
    }

    //esta condicion activa el evento para la temperatura
    if(grados > 0){
      //invocamos el metodo
      delDescongelado(grados);
    }
  }

}