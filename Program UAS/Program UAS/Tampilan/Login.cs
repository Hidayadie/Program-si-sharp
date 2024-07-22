namespace Program_UAS;

public class Login : Menu
{
    //private string Username;
    //private string Password;
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

    public override void Inputan()
    {
        Console.SetCursorPosition(12, 3);
        string Username = Console.ReadLine();
        Console.SetCursorPosition(12, 4);
        string Password = Console.ReadLine();

    }
}
