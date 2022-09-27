namespace serializacionComposicion;
[Serializable]
public class CMotor{
  private int cilindros;
  private int hp;

  public int Cilindros { get=> cilindros; set=> cilindros = value; }
  public int HP { get=> hp; set=> hp = value; }

  public CMotor()
  {
    cilindros = 4;
    hp = 200;
  }
  public CMotor(int pCilindros, int pHP)
  {
    cilindros = pCilindros;
    hp = pHP;
  }

  public void Muestra(){
    Console.WriteLine("===== Cilindros: {0}, HP:{1}", cilindros, hp);
  }

}