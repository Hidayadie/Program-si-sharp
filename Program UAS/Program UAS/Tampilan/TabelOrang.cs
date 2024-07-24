namespace Program_UAS;

public class TabelOrang : Menu
{
    public TabelOrang()
    {
        Tampilkan();
        CetakList(1);
        Inputan();

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

        Console.SetCursorPosition(2, 6);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(2, 6);
        Console.Write("1");
        Console.SetCursorPosition(7, 6);
        Console.Write(Database.orang[0].ID);
        Console.SetCursorPosition(16, 6);
        Console.Write(Database.orang[0].Nama);
        Console.SetCursorPosition(38, 6);
        Console.Write(Database.orang[0].Status);

        int lokasi = 0;
        int index = 0;
        int hal = 1;
        ConsoleKey key;
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:

                    if (lokasi == 0 && hal > 1)
                    {
                        hal--;
                        index--;

                        CetakList(hal);
                        lokasi = 6;


                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);

                        break;
                    }

                    if (lokasi > 0)
                    {
                        Console.ResetColor();
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);

                        lokasi--;
                        index--;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);

                        Console.ResetColor();
                    }


                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (lokasi == 6)
                    {
                        hal++;
                        index++;

                        CetakList(hal);
                        lokasi = 0;

                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);

                        break;
                    }
                    if (lokasi < Database.orang.Count - 1 && index < Database.orang.Count - 1)
                    {
                        Console.ResetColor();
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);
                        lokasi++;
                        index++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(2, 6 + lokasi);
                        Console.Write(index + 1);
                        Console.SetCursorPosition(7, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].ID);
                        Console.SetCursorPosition(16, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Nama);
                        Console.SetCursorPosition(38, 6 + lokasi);
                        Console.Write(Database.orang[0 + index].Status);

                        Console.ResetColor();
                    }

                    break;
                case ConsoleKey.Q:
                    return new MenuSiswa();

                case ConsoleKey.E:
                    //return new Biodata(lokasi);
                    break;

            }
        } while (key != ConsoleKey.Enter);

        Console.ResetColor();
        return new Biodata(Database.orang[index], index);
    }

    private void CetakList(int hal)
    {
        int i = (hal - 1) * 7;
        int max = hal * 7;
        int a = 0;

        // Clear previous data on the console
        for (int b = 0; b < 7; b++)
        {
            Console.SetCursorPosition(2, 6 + b);
            Console.Write("   "); // Clear ID column
            Console.SetCursorPosition(7, 6 + b);
            Console.Write("       "); // Clear Name column
            Console.SetCursorPosition(16, 6 + b);
            Console.Write("                     "); // Clear Status column
        }

        // Display the list of students
        while (i < Database.orang.Count && i < max)
        {
            Console.SetCursorPosition(2, 6 + a);
            Console.Write(i + 1); // Display the index
            Console.SetCursorPosition(7, 6 + a);
            Console.Write(Database.orang[i].ID); // Display the ID
            Console.SetCursorPosition(16, 6 + a);
            Console.Write(Database.orang[i].Nama); // Display the Name
            Console.SetCursorPosition(38, 6 + a);
            Console.Write(Database.orang[i].Status); // Display the Status

            a++;
            i++;
        }
    }

    // for (int i = hal; i < hal *7; i++)
    // {
    //     Console.SetCursorPosition(2, 5 + i);
    //     Console.Write(i);
    //     Console.SetCursorPosition(7, 5 + i);
    //     Console.Write(Database.siswa[i].ID);
    //     Console.SetCursorPosition(16, 5 + i);
    //     Console.Write(Database.siswa[i].Nama);
    //     Console.SetCursorPosition(38, 5 + i);
    //     Console.Write(Database.siswa[i].Status);
    // }    

}
