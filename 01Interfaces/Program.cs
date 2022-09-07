namespace interfaces;

public class Program{
  static void Main(string[] args){
    CSuma suma = new CSuma();
    suma.calcular(4.5, 6.7);
    suma.mostrar();

    ////CARACTERISTICAS POLIMORFICAS
    ///
    int opcion = 0;
    double vala = 0.0;
    double valab = 0.0;

    string valor = "";

    IOperaciones operaciones = new CSuma();

    while(opcion != 5){
      Console.WriteLine("1-SUMA, 2-RESTA, 3-MULT, 4-DIV, 5-SALIR");
      Console.WriteLine("QUE OPCION DESA?");
      valor= Console.ReadLine();
      opcion = Convert.ToInt32(valor);

      Console.WriteLine("DAME EL VALOR DE A");
      vala = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("DAME EL VALOR DE B");
      valab = Convert.ToInt32(Console.ReadLine());

      //POLIMORFISMO
      if(opcion ==1)
        operaciones = new CSuma();
      if(opcion ==2)
        operaciones = new CResta();
      if(opcion ==3)
        operaciones = new CMulti();
      if(opcion ==4)
        operaciones = new CDivision();

      //ACA EL PROGRAMA TRABAJA EN TERMINOS DEL CONCEPTO OPERACIONES, EN LUGAR DE EN TERMINOL DE COSAS MAS CONCRETAS 
      //COMO SUMA, RESTA, MULTIPLICACION O DIVISION
      operaciones.calcular(vala, valab);
      operaciones.mostrar();
    }



  }
}
