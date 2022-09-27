namespace callback;

public class Program {
  static void Main(string[] args){
    //REFRIGERADOR INTELIGENTE - EVENTO POCO ELEMENTO - EVENTO REFRIGERADOR DESCONGELADO

    CRefri miRefri = new CRefri(500, -20);

    Random rnd = new Random();

    //creamos el sink
    //sink1 tiene el codigo que se ejecutara cuando suceda el evento
    CRefriSink sink1 = new CRefriSink();
    CTiendaSink sink2 = new CTiendaSink();


    //adicionamos el sink al refri
    miRefri.AgregarSink(sink1);
    miRefri.AgregarSink(sink2);

    //el refri hace su trabajo
    while(miRefri.Kilos > 0 && sink1.Paro ==false){
      //el refri trabaja y le sacamos kilos al azor
      miRefri.Trabajar(rnd.Next(1, 5));
    }

      //SEGUNDA PARTE sink2

  



  }
}