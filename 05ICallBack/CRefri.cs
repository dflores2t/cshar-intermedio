using System.Collections;

namespace callback;

public class CRefri{
  //CLAS CON LA QUE SE REALIZA TODO EL TRABAJO, CONTIENE UNO O VARIOS METODOS CON LAS CONDICIONES NECESARIAS SI SE CUMPLE O NO UN EVENTO.

  //array list es un arreglo que funciona de manera dinamica, similar a una lista ligada, en el cual podemos adicionar y eliminar elementos en tiempo de ejecucion.
  private ArrayList listaSinks = new ArrayList();

  private int kilosAlimentos = 0;
  private int grados = 0;

  public CRefri(int pKilos, int pGrados){
    //coloca los valores iniciales del refri
    kilosAlimentos = pKilos;
    grados = pGrados;
  }

  //con este metodo adicionamos el sink
  public void AgregarSink(IEventosRefri pSink){
    if(pSink != null){
      listaSinks.Add(pSink);
    }
  }

  //con este metodo eliminamos un sink
  public void EliminarSink(IEventosRefri pSink){
    if(listaSinks.Contains(pSink)){
      listaSinks.Remove(pSink);
    }
  }
//PROPIEDADES NECESARIAS
public int Kilos { get => kilosAlimentos; }
public int Grados { get => grados; }

public void Trabajar(int pConsumo){
    //Actualizamos los kilos del refri
    kilosAlimentos -= pConsumo;

    //subimos la temperatura
    grados += 1;
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("{0} Kilos, {1} Grados ", kilosAlimentos, grados);
  //hay que verificar si se cumple la condicion para invocar los handlers del eveno
  //condicion del evento
  if(kilosAlimentos < 10){
    //invocamos a los handlers de cada sink
    foreach(IEventosRefri handler in listaSinks){
        handler.EReservasBajas(kilosAlimentos);
      }
  }

  //condicion para el evento descongelado
  if(grados >=0){
    //invocamos a los handler de cada sink
    foreach(IEventosRefri handler in listaSinks){
        handler.EDescongelado(grados);
      }
  }


  }
}