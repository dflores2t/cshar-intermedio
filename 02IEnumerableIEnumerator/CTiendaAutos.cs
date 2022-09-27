using System.Collections;

namespace ienumerableienumerator;


public class CTiendaAutos{
  
  private CAuto[] disponibles;

  public CTiendaAutos()
  {
    disponibles = new CAuto[4];

    disponibles[0] = new CAuto("SOUL", 220000.50);
    disponibles[1] = new CAuto("FIT", 175600.70);
    disponibles[2] = new CAuto("MARCH", 168900.00);
    disponibles[3] = new CAuto("SPARK", 160400.40);
  }

  public IEnumerator GetEnumerator(){
    //regresamo la estructura que nos interesa que 
    // recorra el foreach, esta debe de implementar ienumerator
    return disponibles.GetEnumerator();
  }
}