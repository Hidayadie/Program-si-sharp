namespace Program_UAS;

public class Dashboard : Menu
{
    public Dashboard()
    {
        Tampilkan();
        Inputan();

    }

    private string[] kalimat = { "1. Data Siswa  ",
                                 "2. Data Aset   ",
                                 "3. Keluar      "    };
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
        Console.Write("2. Data Aset");

        CetakSamping(6);
        Console.Write("3. Keluar");



        //
        CetakBawah(7);
    }

    public override Menu Inputan()
    {
        Console.SetCursorPosition(2, 4);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(kalimat[0]);

        int lokasi = 0;
        ConsoleKey key;
        do
        {
            // Membaca input dari keyboard
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;

            // Menangani input
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (lokasi > 0)
                    {
                        Console.SetCursorPosition(2, 4 + lokasi);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi--;
                        Console.SetCursorPosition(2, 4 + lokasi);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }

                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (lokasi < 2)
                    {
                        Console.SetCursorPosition(2, 4 + lokasi);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi++;
                        Console.SetCursorPosition(2, 4 + lokasi);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }
                    break;

            }
        } while (key != ConsoleKey.Enter);

        if (lokasi == 0) return new MenuSiswa();
        if (lokasi == 1) return new MenuAset();
        else return null;

    }
}
