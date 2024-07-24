namespace Program_UAS;

public class TabelOrang : Menu
{
    public TabelOrang()
    {
        Tampilkan();
        CetakList();

    }
    public override void Tampilkan()
    {
        Console.Clear();
        CetakAtas("Person");
        CetakSamping(1);
        CetakSamping(2);

        CetakSampingT(3);
        Console.SetCursorPosition(1, 3);
        for (int i = 0; i < 49; i++)
        {
            Console.Write(Hori);
        }
        Console.SetCursorPosition(1, 5);
        for (int i = 0; i < 49; i++)
        {
            Console.Write(Hori);
        }

        CetakSamping(4);
        Console.SetCursorPosition(2, 4);
        Console.Write("No");
        Console.SetCursorPosition(5, 4);
        Console.Write(Verti);
        Console.SetCursorPosition(5, 3);
        Console.Write(TAtas);
        Console.SetCursorPosition(5, 5);
        Console.Write(TBawah);

        Console.SetCursorPosition(7, 4);
        Console.Write("ID");
        Console.SetCursorPosition(14, 4);
        Console.Write(Verti);
        Console.SetCursorPosition(14, 3);
        Console.Write(TAtas);
        Console.SetCursorPosition(14, 5);
        Console.Write(TBawah);

        Console.SetCursorPosition(16, 4);
        Console.Write("Nama");
        Console.SetCursorPosition(37, 4);
        Console.Write(Verti);
        Console.SetCursorPosition(37, 3);
        Console.Write(TAtas);
        Console.SetCursorPosition(37, 5);
        Console.Write(TBawah);

        Console.SetCursorPosition(39, 4);
        Console.Write("Status");

        CetakSampingT(5);


        CetakSamping(6);
        Console.SetCursorPosition(5, 6);
        Console.Write("|");
        Console.SetCursorPosition(14, 6);
        Console.Write("|");
        Console.SetCursorPosition(37, 6);
        Console.Write("|");

        CetakSamping(7);
        Console.SetCursorPosition(5, 7);
        Console.Write("|");
        Console.SetCursorPosition(14, 7);
        Console.Write("|");
        Console.SetCursorPosition(37, 7);
        Console.Write("|");

        CetakSamping(8);
        Console.SetCursorPosition(5, 8);
        Console.Write("|");
        Console.SetCursorPosition(14, 8);
        Console.Write("|");
        Console.SetCursorPosition(37, 8);
        Console.Write("|");

        CetakSamping(9);
        Console.SetCursorPosition(5, 9);
        Console.Write("|");
        Console.SetCursorPosition(14, 9);
        Console.Write("|");
        Console.SetCursorPosition(37, 9);
        Console.Write("|");

        CetakSamping(10);
        Console.SetCursorPosition(5, 10);
        Console.Write("|");
        Console.SetCursorPosition(14, 10);
        Console.Write("|");
        Console.SetCursorPosition(37, 10);
        Console.Write("|");

        CetakSamping(11);
        Console.SetCursorPosition(5, 11);
        Console.Write("|");
        Console.SetCursorPosition(14, 11);
        Console.Write("|");
        Console.SetCursorPosition(37, 11);
        Console.Write("|");

        CetakSamping(12);
        Console.SetCursorPosition(5, 12);
        Console.Write("|");
        Console.SetCursorPosition(14, 12);
        Console.Write("|");
        Console.SetCursorPosition(37, 12);
        Console.Write("|");

        CetakSampingT(13);
        Console.SetCursorPosition(1, 13);
        for (int i = 0; i < 49; i++)
        {
            Console.Write(Hori);
        }

        CetakSamping(14);
        Console.SetCursorPosition(2, 14);
        Console.Write("[q] Kembali");

        Console.SetCursorPosition(18, 14);
        Console.Write("[s] Selengkapnya");

        Console.SetCursorPosition(39, 14);
        Console.Write("[e] Edit");
        CetakBawah(15);
    }

    public override Menu Inputan()
    {
        Console.SetCursorPosition(27, 5);
        Console.BackgroundColor = ConsoleColor.Green;
        //Console.Write(kalimat[0]);

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
                        // Console.SetCursorPosition(27, 5 + lokasi);
                        // Console.ResetColor();
                        // Console.Write(kalimat[lokasi]);
                        // lokasi--;
                        // Console.SetCursorPosition(27, 5 + lokasi);
                        // Console.BackgroundColor = ConsoleColor.Green;
                        // Console.Write(kalimat[lokasi]);
                    }


                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (lokasi < 2)
                    {
                        // Console.SetCursorPosition(27, 5 + lokasi);
                        // Console.ResetColor();
                        // Console.Write(kalimat[lokasi]);
                        // lokasi++;
                        // Console.SetCursorPosition(27, 5 + lokasi);
                        // Console.BackgroundColor = ConsoleColor.Green;
                        // Console.Write(kalimat[lokasi]);
                    }

                    break;
                case ConsoleKey.Q:
                    return new MenuSiswa();

                case ConsoleKey.E:
                    return new EditOrang(lokasi);

            }
        } while (key != ConsoleKey.Enter);

        Console.ResetColor();
        if (lokasi == 0) return new TabelOrang();
        if (lokasi == 1) return new Login();
        if (lokasi == 2) return new Dashboard();
        else return new TabelOrang();
    }

    private void CetakList()
    {


        Database.siswa.Add(new Siswa("Adie", "123", "12A", "Ipa"));

        int i = 1;
        foreach (Siswa siswa in Database.siswa)
        {
            Console.SetCursorPosition(2, 5 + i);
            Console.Write(i);
            Console.SetCursorPosition(8, 5 + i);
            Console.Write(siswa.ID);
            Console.SetCursorPosition(16, 5 + i);
            Console.Write(siswa.Nama);
            Console.SetCursorPosition(38, 5 + i);
            Console.Write("Siswa Aktif");
            i++;
        }
    }
}
