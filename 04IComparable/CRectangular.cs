namespace icomparable;

public class CRectangular : IComparable{

  private double ancho;
  private double alto;
  private double area;

  public CRectangular(double pAncho, double pAlto)
  {
    ancho = pAncho;
    alto = pAlto;
    CalculaArea();
  }
  private void CalculaArea(){
    area = ancho * alto;
  }

  public override string ToString()
  {
    return string.Format("[{0},{1}] = {2}", ancho, alto, area);
  }

  int IComparable.CompareTo(object? obj)
  {
    //HACEMOS TYPE CAST CON EL OBJETO CON EL CUAL NOS VAMOS A COMPARAR
    CRectangular temp = (CRectangular)obj;

    //SI SOMOS MAS GRANDE QUE EL OBJETO REGRESAMOS 1
    if(area > temp.area)
      return 1;

    //SI SOMOSO MAS PEQUENOS QUE EL OBJETO REGRESAMOS -1
    if(area < temp.area)
      return -1;
    // SOMOS IGUALES AL OBJETO REGRESAMOS 0
    return 0;
  }
}