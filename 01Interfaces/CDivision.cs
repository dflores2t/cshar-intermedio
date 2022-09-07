namespace interfaces;

public class CDivision: IOperaciones
{

  private double r = 0;
  //METODOS A IMPLEMENTARE

  public void calcular(double a, double b)
  {
    r = a / b;
  }

  public void mostrar()
  {
    Console.WriteLine("EL RESULTADO DE LA DIVISION ES :{0}", r);
  }
}