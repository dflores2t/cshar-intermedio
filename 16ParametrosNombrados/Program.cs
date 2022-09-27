namespace prametrosNombrados{
  public class Program{

    static void Main(string[] args){
      //invocamos la funcion de forma normal
      //tres posiciones
      //parametros nombrados
      mostraDatos(3, 5, 7); //parametros posicionales cae en las posiciones designadas.


      /*
        NOMBRADOS
        INVOCAMOS LA FUNCION CON PRIMERO EN NORMAL, LOS DEMAS EN OTRO ORDEN
        UN POSICIONAL, DOS NOMBRADOS
      */
      Console.WriteLine("----------------PARAMETROS NOMBRADOS------------------");
      mostraDatos(3, pC: 11, pB: 15);

      //INVOCAMOS LOS DATOS EN OTRO ORDEN
      //TRES NOMBRADOS
      Console.WriteLine("---------------OTRO PARAMETRO NOMBRADOS---------------");
      mostraDatos(pB: 10, pC: 15, pA: 4);

      //UN POSICIONAL NO PUEDE VENIR DESPUES DE UN NOMBRAD
      // mostraDatos(pB: 5, 7, 8); // error no lo permite el lenguaje

      //PARAMETROS OPCIONALES
      //SE LLAMAN TAMBIEN PARAMETROS DE DEFGAULT
      Console.WriteLine("-------------PARAMETROS OPCIONALES---------------------");
      mostraDatosOpcionales(11, 12, 13);
      Console.WriteLine("usamos dos parametros c usara el opcional");
      mostraDatosOpcionales(20,21);
      Console.WriteLine("USAMOS UN PARAMETRO , B Y C USARA SU VALOR DE DEFAULT");
      mostraDatosOpcionales(31);
      Console.WriteLine("USAMOS TODOS LOS PARAMETROS OPCIONALES");
      mostraDatosOpcionales();
      Console.WriteLine("AHORA CON NOMBRADOS Y OPCIONALES");
      mostraDatosOpcionales(pC: 67, pB: 45);
      Console.WriteLine("DOS OPCIONALES CON UN NOMBRADO");
      mostraDatosOpcionales(pB: 56);

    }


  public static void mostraDatos(int pA, int pB, int pC){
    Console.WriteLine("EL VALOR DE A ES {0}",pA);
    Console.WriteLine("EL VALOR DE B ES {0}",pB);
    Console.WriteLine("EL VALOR DE C ES {0}",pC );
  }
  public static void mostraDatosOpcionales(int pA=1, int pB=2, int pC=3){
    Console.WriteLine("EL VALOR DE A ES {0}",pA);
    Console.WriteLine("EL VALOR DE B ES {0}",pB);
    Console.WriteLine("EL VALOR DE C ES {0}",pC );
  }
  }

}