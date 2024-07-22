namespace Program_UAS;

public abstract class Menu : InterfaceMenu
{
    private string Judul = "MENU";
    private char AtasKiri = '┌';
    private char BawahKiri = '└';
    private char AtasKanan = '┐';
    private char BawahKanan = '┘';

    private char Hori = '─';
    private char Verti = '│';
    public virtual void Tampilkan()
    {
        Console.Clear();
        

        CetakAtas();
        Console.Write(Verti);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("        Override...       ");
        Console.ResetColor();
        Console.Write(Verti);
        CetakBawah();


    }

    public virtual void Pilihan()
    {
        //throw new NotImplementedException();
    }

    public int UkurString(string foo)
    {
        return foo.Length;
    }

    public void CetakAtas()
    {
        Console.Write(AtasKiri);
        Console.Write(Hori);
        Console.Write(Judul);
        for (int i = 0; i < 25 - UkurString(Judul); i++) {
            Console.Write(Hori);
        }
        Console.Write(AtasKanan);
        Console.Write("\n");
    }

    public void CetakBawah()
    {
        Console.Write("\n");
        Console.Write(BawahKiri);
        for (int i = 0; i < 22 + UkurString(Judul); i++) {
            Console.Write(Hori);
        }
        Console.Write(BawahKanan);
        Console.Write("\n");
    }
}