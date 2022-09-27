namespace SobreCargaOperadores;
public class Program {
  static void Main(string[] args){
    CImaginario im1 = new CImaginario(1, 2);
    CImaginario im2 = new CImaginario(3, 4);
    CImaginario imr;
    //hacemos la suma
    imr = im1 + im2;
    Console.WriteLine("{0} + {1} ={2}", im1,im2,imr);
    //hacemos la resta
    imr = im1 - im2;
    Console.WriteLine("{0} - {1} ={2}", im1,im2,imr);
    //hacemos la suma
    imr = im1 * im2;
    Console.WriteLine("{0} * {1} ={2}", im1,im2,imr);
    //hacemos la suma
    imr = im1 / im2;
    Console.WriteLine("{0} / {1} ={2}", im1,im2,imr);
  }
}