namespace indexer;

public class Program{
  static void Main(string[] args){
    int n = 0;

    //creamos la tienda
    CTiendaAuto miTienda = new CTiendaAuto();

    //obtenemos un auto
    CAuto miAuto = miTienda[1];
    miAuto.MuestraInformacion();

    //colocamos un auto
    CAuto otroAuto = new CAuto("VOCHO", 85000);
    miTienda[1] = otroAuto;

    //mostramos en pantalla el arreglo en tienda
    for (n = 0; n < 4; n++)
    {
      miTienda[n].MuestraInformacion();
    }
  }
}