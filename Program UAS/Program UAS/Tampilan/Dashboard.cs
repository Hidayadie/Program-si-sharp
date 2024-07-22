namespace Program_UAS;

public class Dashboard : Menu
{

    private string[] kalimat = { "1. Data Siswa  ",
                                 "2. Data Benda  ",
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
        Console.Write("2. Data Benda");

        CetakSamping(6);
        Console.Write("3. Keluar");



        //
        CetakBawah(7);
    }

    public override async void Inputan()
    {
        Console.SetCursorPosition(2, 4);
        //Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(kalimat[0]);

        int lokasi = 0;
        while (true)
        {
            // Membaca input dari keyboard
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            ConsoleKey key = keyInfo.Key;

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
                        Console.BackgroundColor = ConsoleColor.White;
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
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(kalimat[lokasi]);
                    }
                    break;

                case ConsoleKey.Enter:
                    return;


                default:
                    return;
            }
        }

    }
}
