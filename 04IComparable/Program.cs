namespace icomparable;

public class Program{
  static void Main(string[] args){
    CRectangular[] rects = new CRectangular[5];

    rects[0] = new CRectangular(7, 5);
    rects[1] = new CRectangular(6, 4);
    rects[2] = new CRectangular(4, 3);
    rects[3] = new CRectangular(7, 6);
    rects[4] = new CRectangular(5, 7);

    //IMPRMIMIMOS ARREGLO ORIGINAL
    foreach(CRectangular r in rects){
      Console.WriteLine(r);
    }
    Console.WriteLine("-------------------------------");
    //HACEMOS USO DE SORT, EL CUAL NECESITA LA IMPLEMENTACION DE ICOMPARABLE
    Array.Sort(rects);

    //IMPRIMIMOS UN ARREGLO ORDENADO
    foreach(CRectangular r in rects){
      Console.WriteLine(r);
    }
  }
}