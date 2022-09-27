namespace SobreCargaOperadoresUnuarios;

public class CImaginario :IComparable{
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
    public static CImaginario operator +(CImaginario i1, CImaginario i2)
  {
    //debe ser publico statico tipo de retorno
    double re = 0;
    double ri = 0;
    re = i1.entero + i2.entero;
    ri = i1.imaginario + i2.imaginario;

    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }

  //sobre carga para el operador -
  public static CImaginario operator -(CImaginario i1, CImaginario i2)
  {
    double re = 0;
    double ri = 0;

    re = i1.entero - i2.entero;
    ri = i1.imaginario - i2.imaginario;
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }
  //sobre carga para el operador *
  public static CImaginario operator *(CImaginario i1, CImaginario i2)
  {
    double re = 0;
    double ri = 0;

    re = (i1.entero * i2.entero) - (i1.imaginario * i2.imaginario);
    ri = (i1.entero * i2.imaginario) + (i1.Imaginario * i2.Entero);
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }
  //sobre carga para el operador /
  public static CImaginario operator /(CImaginario i1, CImaginario i2)
  {
    double re = 0;
    double ri = 0;

    re = ((i1.entero * i2.entero) + (i1.entero * i2.imaginario)) / ((i2.entero * i2.entero) + (i1.entero * i2.imaginario));
    ri = ((i1.imaginario * i2.entero) - (i1.entero * i2.imaginario)) / ((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));
    CImaginario temp = new CImaginario(re, ri);
    return temp;
  }

  //SOBRE CARGA DE OPERADORES UNUARIOS
  public static CImaginario operator ++(CImaginario i1){
    CImaginario temp = new CImaginario(i1.Entero + 1, i1.imaginario + 1);
    return temp;
  }

  public static CImaginario operator --(CImaginario i1){
    CImaginario temp = new CImaginario(i1.Entero - 1, i1.imaginario - 1);
    return temp;
  }

  //SOBRECARGO DEL OPERADOR DE IGUALDAD Y DESIGUALDA 
  public override bool Equals(object? obj) //equals biene de object
  {
    //verificamos que sea del tipo correcto
    if(obj is CImaginario){
      CImaginario temp = (CImaginario)obj;
      //compaaramos por igualdad
      if(imaginario == temp.Imaginario && entero == temp.entero){
        return true;
      }
    }
    return false;
  }

  public static bool operator ==(CImaginario i1,CImaginario i2){
    return i1.Equals(i2);
  }

  public static bool operator !=(CImaginario i1, CImaginario i2){
    return !(i1.Equals(i2));
  }

  public override int GetHashCode()
  {
    throw new NotImplementedException();
  }


  //SOBRECARGA DE < Y > NECESITAMOS ICOMPARABLE

  public double magnitud(){
    double m = 0;
    m = Math.Sqrt((entero * entero) + (imaginario * imaginario));
    return m;
  }

  public int CompareTo(object? obj)
  {
    if(obj is CImaginario){
      CImaginario temp = (CImaginario)obj;
      if(magnitud() > temp.magnitud())
        return 1;
      if(magnitud() < temp.magnitud())
        return -1;
    }
    return 0;
  }

  public static bool operator <(CImaginario i1, CImaginario i2){
    if(i1.CompareTo(i2) < 0)
      return true;
    else
      return false;
  }
  public static bool operator >(CImaginario i1, CImaginario i2){
    if(i1.CompareTo(i2) > 0)
      return true;
    else
      return false;
  }




}