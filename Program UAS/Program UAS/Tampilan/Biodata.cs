namespace Program_UAS;

public class Biodata : Menu
{
    private Orang orang;
    private int index;
    private string[] kalimat = { "Kembali",
                                 "Detail",
                                 "Edit"        ,
                                 "prev"        ,
                                 "next"        };
    public Biodata(Orang orang, int index)
    {
        this.orang = orang;
        this.index = index;
        Tampilkan();
        orang.Tampilkan();
        Inputan();

    }

    public override void Tampilkan()
    {
        Console.Clear();
        CetakAtas("*");
        CetakSamping(1);
        Console.SetCursorPosition(25 - (UkurString("Data Pribadi") / 2), 1);
        Console.Write("Data Pribadi");

        CetakSamping(2);
        CetakSamping(3);
        Console.Write("Nama");
        Console.SetCursorPosition(17, 3);
        Console.Write(":");

        CetakSamping(4);
        Console.Write("Nomor Induk");
        Console.SetCursorPosition(17, 4);
        Console.Write(":");

        CetakSamping(5);
        Console.Write("Jenis Kelamin");
        Console.SetCursorPosition(17, 5);
        Console.Write(":");

        CetakSamping(6);
        Console.Write("Status");
        Console.SetCursorPosition(17, 6);
        Console.Write(":");

        if (orang is Siswa siswa)
        {
            CetakSamping(7);
            Console.Write("Kelas");
            CetakSamping(8);
            Console.Write("Jurusan");
        }
        if (orang is Guru guru)
        {

        }
        if (orang is Karyawan karyawan)
        {

        }
        else
        {
            CetakSamping(7);
            CetakSamping(8);
        }

        Console.SetCursorPosition(17, 7);
        Console.Write(":");
        Console.SetCursorPosition(17, 8);
        Console.Write(":");

        CetakSamping(9);
        CetakSampingT(10);
        Console.SetCursorPosition(1, 10);
        for (int i = 0; i < 49; i++)
        {
            Console.Write(Hori);
        }


        CetakSamping(11);
        Console.SetCursorPosition(3, 11);
        Console.Write(kalimat[0]);
        Console.SetCursorPosition(13, 11);
        Console.Write(kalimat[1]);
        Console.SetCursorPosition(23, 11);
        Console.Write(kalimat[2]);
        Console.SetCursorPosition(33, 11);
        Console.Write(kalimat[3]);
        Console.SetCursorPosition(43, 11);
        Console.Write(kalimat[4]);

        CetakBawah(12);
    }

    public override Menu Inputan()
    {
        Console.SetCursorPosition(3, 11);
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
                        Console.SetCursorPosition(3 + (lokasi * 10), 11);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi--;
                        Console.SetCursorPosition(3 + (lokasi * 10), 11);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }


                    break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (lokasi < 4)
                    {
                        Console.SetCursorPosition(3 + (lokasi * 10), 11);
                        Console.ResetColor();
                        Console.Write(kalimat[lokasi]);
                        lokasi++;
                        Console.SetCursorPosition(3 + (lokasi * 10), 11);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(kalimat[lokasi]);
                    }

                    break;
            }

        } while (key != ConsoleKey.Enter);

        Console.ResetColor();
        if (lokasi == 0) return new TabelOrang();
        if (lokasi == 1) return new Login();
        if (lokasi == 2) return new Login();
        if (lokasi == 3) return new Biodata(Database.orang[(index == 0) ? 0 : --index], index);
        if (lokasi == 4) return new Biodata(Database.orang[(index == Database.orang.Count) ? Database.orang.Count : ++index], index);


        else return null;
    }

}
