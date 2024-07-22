namespace Program_UAS;

public class Dashboard : Menu
{

    public override void Tampilkan()
    {
        Console.Clear();


        CetakAtas("DASHBOARD");
        //

        CetakSamping(1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(25 - (UkurString("Selamat datang") / 2), 1);
        Console.Write("Selamat Datang");

        Console.ResetColor();
        CetakSamping(2);
        Console.Write("Data administrasi sekolah \"SMA Kayangan\"");

        CetakSamping(3);
        Console.Write("Pilih menu:");

        CetakSamping(4);
        Console.Write("1. Data Siswa");

        CetakSamping(5);
        Console.Write("2. Data Benda");

        CetakSamping(6);
        Console.Write("3. Keluar");



        //
        CetakBawah(7);
    }
}
