namespace SobreCargaOperadoresUnuarios;

public class Program{
  static void Main(string[] args){
    CImaginario im1 = new CImaginario(1, 2);
    CImaginario im2 = new CImaginario(3, 4);
    // Console.WriteLine("------------INCREMENTO--------------");
    // Console.WriteLine(im1);
    // im1++;
    // Console.WriteLine(im1);
    // Console.WriteLine("-------------DECREMENTO-------------");
    // Console.WriteLine(im2);
    // im2--;
    // Console.WriteLine(im2);
    // Console.WriteLine("----------------SUMATORIA--------------");
    // Console.WriteLine(im1);
    // im1 += im2;
    // Console.WriteLine(im1);
     CImaginario im3 = new CImaginario(5, 7);

    //
    if(im1 == im3){
      Console.WriteLine("SON IGUALES");
    }
    if(im2 != im1){
      Console.WriteLine("SON DIFERENTES");
    }
    if(im1 < im3){
      Console.WriteLine("IM1 ES MENOR");
    }
    if(im2 > im1){
      Console.WriteLine("IM2 ES MAYOR");
    }

  }
}