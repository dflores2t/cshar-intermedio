namespace indexer;
//en ele interior de tienda aauto podemos tener un arreglo o lo que sea para guardare el listado de autos
// y del exterior pueda trabajar con esos autoso de manera sencilla sin complicarlo tanto con funciones de interface
//crear un indixer de tal manera que el exterior a la clase tienda auto pueda modificar la infomacion de ese arrgelo de la manera mas sencilla posible
public class CTiendaAuto{
  private CAuto[] disponibles;

  public CTiendaAuto()
  {
    disponibles = new CAuto[4];

    disponibles[0] = new CAuto("SOUL", 220000.50);
    disponibles[1] = new CAuto("FIT", 175600.70);
    disponibles[2] = new CAuto("MARCH", 168900.00);
    disponibles[3] = new CAuto("SPARK", 160400.40);
  }

  //AQUI CREAMOS EL INDEXER
  //this -> para que podamos utilizar la clase o el objeto creado y a traves de este objeto indicar el indice que me interesa.
  public CAuto this[int indice]{
    //usamos un get para obtener el elemento en ese indice
    get => disponibles[indice];

    //usamos set para colocar un elemento en ese indice /falta codigo de seguidad
    set => disponibles[indice] = value;
  }

}