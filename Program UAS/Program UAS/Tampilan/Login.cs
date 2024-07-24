namespace Program_UAS;

public class Login : Menu
{
    public Login()
    {
        Tampilkan();
        Inputan();
    }
    private string Username = "";
    private string Password = "";
    public override void Tampilkan()
    {
        Console.Clear();


        CetakAtas("LOGIN");
        //

        CetakSamping(1);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(25 - (UkurString("Silahkan Login terlebih dahulu") / 2), 1);
        Console.Write("Silahkan Login terlebih dahulu");
        Console.ResetColor();


        CetakSamping(2);


        CetakSamping(3);
        Console.Write("Username: ");


        CetakSamping(4);
        Console.Write("Password: ");

        CetakSamping(5);


        //
        CetakBawah(6);
    }

    public override Menu Inputan()
    {
        do
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(12, 3);
            Username = Console.ReadLine() ?? ""; ;
            Console.SetCursorPosition(12, 4);
            Password = Console.ReadLine() ?? ""; ;
            Console.CursorVisible = false;
            if (Username == "Admin" && Password == "admin123") break;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25 - (UkurString("User atau password salah") / 2), 2);
            Console.Write("User atau password salah");
            Console.ResetColor();
            Console.SetCursorPosition(12, 3);
            Console.Write("                         ");
            Console.SetCursorPosition(12, 4);
            Console.Write("                         ");

        } while (true);
        return new Dashboard();
    }
}
