namespace icloneable;

public class Program
{
  static void Main(string[] args)
  {

    //CASO DONDE NO HAY CLONACION,
    CAuto auto1 = new CAuto("MARCH", 170000);
    //AQUI PENSAMOS QUE HACEMOS CLONADO, PERO SOLO ES  OTRA VARIABLE REFERENCIADA A LA MISMA INSTANCIA
    CAuto auto2 = auto1;
    //LLEVAMOS A CABO OPERACIONES
    auto1.CalculaTenencia(0.10);
    auto2.CalculaTenencia(0.10);

    //MOSTRAMOS LOS RESULTADOS
    auto1.MuestraInformacion();
    auto2.MuestraInformacion();

    Console.WriteLine("---------------------");

    //HACEMOS UN CAMBIO, SI FGUERA UN CLON SOLO UNO CAMBIA
    auto1.Costo = 60000;
    //MOSTRAMOS LOS DATOS
    auto1.MuestraInformacion();
    auto2.MuestraInformacion();
    //HASTA ACA LO QUE PARECIA UNA CLONACION NO ES MAS QUE UNA REFERENCIA DE OBJETOS AL MODIFICAR LOS DATOS DE 1 OBJETO SE VALIDA PARA AMBOS
    Console.WriteLine("<===============================>");

    //LLEVAMOS ACABO LA CLONACION
    // MODIFICAR LA CLASE CAUTO Y AGREGAR LA INTERFAZ ICLONEABLE

    CAuto auto3 = (CAuto)auto1.Clone();
    auto1.MuestraInformacion();
    auto3.MuestraInformacion();
    Console.WriteLine("----------------INFORMACION DE LOS OBJETOS CLONADO-----------");
    //MODIFICAMOS UNO DE LOS OBJETOS
    auto1.Costo = 250000;
    //MOSTRAMOS LOS RESULTADOS
    auto1.MuestraInformacion();
    auto3.MuestraInformacion();
    Console.WriteLine("==============================================");
  }
}