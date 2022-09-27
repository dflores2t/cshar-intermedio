namespace SobreCargaOperadores;

public class CImaginario{
  //ATRIBUTOS
  private double entero;
  private double imaginario;

  public CImaginario(double pEntero, double pImaginario)
  {
    entero = pEntero;
    imaginario = pImaginario;
  }
  //propiedades
  public double Entero { get=> entero; set=> entero = value; }
  public double Imaginario { get => imaginario; set=> imaginario = value; }

  //para mostrar el numero imaginario
  public override string ToString()
  {
    if(imaginario < 0){
      return string.Format("{0} {1}i", entero, imaginario);
    }else{
      return string.Format("({0} + {1}i)", entero, imaginario);
    }
  }

    //SOBRE CARGA DE LOS OPERADORES BINARIOS
    //a = i1 + i2
    public static CImaginario operator +(CImaginario i1, CImaginario i2){
    //debe ser publico statico tipo de retorno
    double re = 0;
    double ri = 0;
    re = i1.entero + i2.entero;
    ri = i1.imaginario + i2.imaginario;

    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }

  //sobre carga para el operador -
  public static CImaginario operator -(CImaginario i1, CImaginario i2){
    double re = 0;
    double ri = 0;

    re = i1.entero - i2.entero;
    ri = i1.imaginario - i2.imaginario;
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }
  //sobre carga para el operador *
  public static CImaginario operator *(CImaginario i1, CImaginario i2){
    double re = 0;
    double ri = 0;

    re = (i1.entero * i2.entero) - (i1.imaginario * i2.imaginario);
    ri = (i1.entero * i2.imaginario)+(i1.Imaginario * i2.Entero);
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }
  //sobre carga para el operador /
  public static CImaginario operator /(CImaginario i1, CImaginario i2){
    double re = 0;
    double ri = 0;

    re = ((i1.entero * i2.entero) + (i1.entero * i2.imaginario)) / ((i2.entero * i2.entero) + (i1.entero * i2.imaginario));
    ri = ((i1.imaginario * i2.entero)- (i1.entero * i2.imaginario)) / ((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }

    
}