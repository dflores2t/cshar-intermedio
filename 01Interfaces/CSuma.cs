using System.Collections;

namespace interfaces;

public class CSuma: IOperaciones
{
  private double r = 0.0;
  private ArrayList resultado = new ArrayList();
  
  public void calcular(double a, double b)
  {
    r = a + b;
  }

  public void mostrar()
  {
    Console.WriteLine("EL RESULTADO DE LA SUMA ES : {0}",r);
    resultado.Add(r);
  }

  //METODO PROPIO DE LA CLASE
  public void muestraResultados(){
    foreach(double r in resultado){
      Console.WriteLine(r);
    }
  }
}