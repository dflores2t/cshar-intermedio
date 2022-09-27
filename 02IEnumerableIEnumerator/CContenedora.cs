using System.Collections;

namespace ienumerableienumerator;

public class CContenedora: IEnumerable{
  private int[] valores = new int[10];

  public CContenedora()
  {
    for (int n = 0; n < 10; n++){
      valores[n] = n * n;
    }    
  }

    //IMPLEMENTAMOS EL GETENUMERATOR NECESARIO PARA IENUMERABLE
  IEnumerator IEnumerable.GetEnumerator()
  {
    //intanciamos el enumerador y lo regresamos
    return (new ContenedorEnum(valores));
  }
}

class ContenedorEnum : IEnumerator{
  public int[] arrgelo;
  private int posicion = -1;
  public ContenedorEnum(int[] pArreglo)
  {
    arrgelo = pArreglo;
  }

  public bool MoveNext()
  {
    posicion++;
    if(posicion < arrgelo.Length){
      return true;
    }else{
      return false;
    }
  }

  public void Reset()
  {
    posicion = -1;
  }

  public object Current{
    get => arrgelo[posicion];
  } 


}