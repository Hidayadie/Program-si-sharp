namespace Program_UAS;

public abstract class Menu : InterfaceMenu
{
    protected string Judul = "MENU";
    private protected char AtasKiri = '┌';
    private protected char BawahKiri = '└';
    private protected char AtasKanan = '┐';
    private protected char BawahKanan = '┘';
    private protected char Hori = '─';
    private protected char Verti = '│';



    public virtual void Tampilkan()
    {
        Console.Clear();
        

        CetakAtas(Judul);
        //

        CetakSamping(1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(20 - (UkurString(" ! Override ! ") / 2), 1);
        Console.Write(" ! Override ! ");
        Console.ResetColor();
        


        //
        CetakBawah(Judul, 2);


    }

    public virtual void Inputan()
    {
        //throw new NotImplementedException();
    }

    public int UkurString(string foo)
    {
        return foo.Length;
    }

    public void CetakAtas(string teks)
    {
        Console.SetCursorPosition(0,0);
        Console.Write(AtasKiri);
        for (int i = 0; i < 40; i++) {
            Console.Write(Hori);
        }
        Console.SetCursorPosition(40,0);
        Console.Write(AtasKanan);

        Console.SetCursorPosition(20 - (UkurString(Judul) / 2),0);
        Console.Write(teks);
        Console.Write("\n");
    }

    public void CetakBawah(string teks, int y)
    {
        Console.SetCursorPosition(0, y);
        Console.Write(BawahKiri);
        for (int i = 0; i < 40; i++) {
            Console.Write(Hori);
        }
        Console.SetCursorPosition(40, y);
        Console.Write(BawahKanan);
        Console.Write("\n");
    }

    public void CetakSamping(int y)
    {
        Console.SetCursorPosition(0,y);
        Console.Write(Verti);
        Console.SetCursorPosition(40,y);
        Console.Write(Verti);
        Console.SetCursorPosition(2,y);
        
    }
}