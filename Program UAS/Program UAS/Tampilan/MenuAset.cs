using System.Runtime.CompilerServices;

namespace Program_UAS;

public class MenuAset : Menu
{
    public MenuAset()
    {
        Tampilkan();
        Inputan();
    }
    private string[] kalimat = { "Kembali",
                                 "Tampilkan",
                                 "Edit"};
    public override void Tampilkan()
    {

        Console.Clear();
        CetakAtas("ASET INVENTARIS");
        //

        CetakSamping(1);

        Console.Write("Database Inventaris dan aset yang terdaftar pada");


        CetakSamping(2);
        Console.Write("SMA Kayangan");

        CetakSamping(3);
        Console.SetCursorPosition(1, 3);
        for (int i = 0; i < 49; i++)
        {
            Console.Write("-");
        }

        CetakSamping(4);
        CetakSamping(5);
        Console.Write("Fasilitas layak Pakai : 7 ");
        Console.SetCursorPosition(31, 5);
        Console.Write("Inventaris yang di-");

        CetakSamping(6);
        Console.Write("Fasilitas rusak ringan: 8 ");
        Console.SetCursorPosition(31, 6);
        Console.Write("hitung belum melip-");


        CetakSamping(7);
        Console.Write("Fasilitas Rusat Berat : 2 ");
        Console.SetCursorPosition(31, 7);
        Console.Write("uti koleksi Perpus");

        CetakSamping(8);
        Console.Write("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");



        CetakSamping(9);
        Console.Write("Total                 : 17");

        CetakSamping(10);
        Console.SetCursorPosition(1, 10);
        for (int i = 0; i < 49; i++)
        {
            Console.Write("=");
        }
        CetakSamping(10);

        CetakSamping(11);
        Console.SetCursorPosition(2, 11);
        Console.Write("Kembali");

        Console.SetCursorPosition(22, 11);
        Console.Write("Tampilkan");

        Console.SetCursorPosition(42, 11);
        Console.Write("Edit");

        //
        CetakBawah(12);
    }

    public override Menu Inputan()
    {
        Console.SetCursorPosition(2, 11);
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
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (lokasi > 0)
                    {
                        Console.SetCursorPosition(2 + (lokasi * 20), 11);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi--;
                        Console.SetCursorPosition(2 + (lokasi * 20), 11);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }


                    break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (lokasi < 2)
                    {
                        Console.SetCursorPosition(2 + (lokasi * 20), 11);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi++;
                        Console.SetCursorPosition(2 + (lokasi * 20), 11);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }

                    break;
            }

        } while (key != ConsoleKey.Enter);

        Console.ResetColor();
        if (lokasi == 0) return new Dashboard();
        if (lokasi == 1) return new Login();
        if (lokasi == 2) return new Login();

        else return null;
    }
}
