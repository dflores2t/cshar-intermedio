namespace ienumerableienumerator;

public class Program {
  static void Main(string[] args){
    //creamos la tienda
    CTiendaAutos tienda = new CTiendaAutos();

    // recorremos cada una de los elementos de la estructura que expone
    foreach(CAuto miAuto in tienda){
      miAuto.CalculaTenencia(0.05); // impuesto especial automovil
      miAuto.MuestraInformacion();
    }


    //SEGUNDA PARTE
    CContenedora datos = new CContenedora();
    foreach (int valor in datos)
    {
      Console.WriteLine(valor);
    }
  }
}