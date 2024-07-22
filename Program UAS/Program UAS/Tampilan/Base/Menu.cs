namespace Program_UAS;

public abstract class Menu : InterfaceMenu
{
    private string Judul = "MENU";
    private char AtasKiri = '┌';
    private char BawahKiri = '└';
    private char AtasKanan = '┐';
    private char BawahKanan = '┘';

    public virtual void Tampilkan()
    {
        //throw new NotImplementedException();
        Console.Write(AtasKiri);
        Console.Write(AtasKanan);
        Console.Write("\n");
        Console.Write(BawahKiri);
        Console.Write(BawahKanan);


    }

    public virtual void Pilihan()
    {
        //throw new NotImplementedException();
    }

}