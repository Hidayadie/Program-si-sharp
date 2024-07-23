namespace Program_UAS;

public class MenuSiswa : Menu
{

    public MenuSiswa()
    {
        Tampilkan();
        Inputan();
    }
    private string[] kalimat = { "Tampilkan Keseluruhan ",
                                 "Edit Database         ",
                                 "Kembali               "};
    public override void Tampilkan()
    {

        Console.Clear();
        CetakAtas("WARGA SEKOLAH");
        //

        CetakSamping(1);
        Console.Write("Database individu yang terdaftar di SMA Kayangan");

        CetakSamping(2);
        Console.Write(" ");

        CetakSamping(3);
        Console.SetCursorPosition(1, 3);
        for (int i = 0; i < 49; i++)
        {
            Console.Write("-");
        }

        CetakSamping(4);

        CetakSamping(5);
        Console.Write("Jml Siswa    : 7 ");
        Console.SetCursorPosition(25, 5);
        Console.Write("| Tampilkan Keseluruhan");

        CetakSamping(6);
        Console.Write("Jml Guru     : 8 ");
        Console.SetCursorPosition(25, 6);
        Console.Write("| Edit Database");

        CetakSamping(7);
        Console.Write("Jml Karyawan : 2 ");
        Console.SetCursorPosition(25, 7);
        Console.Write("| Kembali");

        CetakSamping(8);
        Console.Write("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
        Console.SetCursorPosition(25, 8);
        Console.Write("|");

        CetakSamping(9);
        Console.Write("Total        : 17");

        CetakSamping(10);
        //
        CetakBawah(11);
    }


    public override Menu Inputan()
    {
        Console.SetCursorPosition(27, 5);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(kalimat[0]);

        int lokasi = 0;
        ConsoleKey key;
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (lokasi > 0)
                    {
                        Console.SetCursorPosition(27, 5 + lokasi);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi--;
                        Console.SetCursorPosition(27, 5 + lokasi);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }


                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (lokasi < 2)
                    {
                        Console.SetCursorPosition(27, 5 + lokasi);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi++;
                        Console.SetCursorPosition(27, 5 + lokasi);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }

                    break;

            }
        } while (key != ConsoleKey.Enter);

        if (lokasi == 0) return new Login();
        if (lokasi == 1) return new Login();
        if (lokasi == 2) return new Dashboard();
        else return new Login();

    }
}
