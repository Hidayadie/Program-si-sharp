namespace Program_UAS;

public abstract class Menu : InterfaceMenu
{

    private protected char AtasKiri = '┌';
    private protected char BawahKiri = '└';
    private protected char AtasKanan = '┐';
    private protected char BawahKanan = '┘';
    private protected char Hori = '─';
    private protected char Verti = '│';



    public virtual void Tampilkan()
    {
        Console.Clear();

        CetakAtas("MENU");
        //

        CetakSamping(1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(25 - (UkurString(" ! Override ! ") / 2), 1);
        Console.Write(" ! Override ! ");
        Console.ResetColor();

        //
        CetakBawah(2);


    }

    public virtual Menu Inputan()
    {
        //throw new NotImplementedException();
        return new Login();
    }

    public int UkurString(string foo)
    {
        return foo.Length;
    }

    public void CetakAtas(string teks)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(AtasKiri);
        for (int i = 0; i < 50; i++)
        {
            Console.Write(Hori);
        }
        Console.SetCursorPosition(50, 0);
        Console.Write(AtasKanan);

        Console.SetCursorPosition(25 - (UkurString("[" + teks + "]") / 2), 0);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write("[" + teks + "]");
        Console.ResetColor();
    }

    public void CetakBawah(int y)
    {
        Console.SetCursorPosition(0, y);
        Console.Write(BawahKiri);
        for (int i = 0; i < 50; i++)
        {
            Console.Write(Hori);
        }
        Console.SetCursorPosition(50, y);
        Console.Write(BawahKanan);
        Console.Write("\n");
    }

    public void CetakSamping(int y)
    {
        Console.SetCursorPosition(0, y);
        Console.Write(Verti);
        Console.SetCursorPosition(50, y);
        Console.Write(Verti);
        Console.SetCursorPosition(2, y);

    }
}