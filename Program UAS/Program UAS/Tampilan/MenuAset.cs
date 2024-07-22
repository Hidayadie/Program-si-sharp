namespace Program_UAS;

public class MenuAset : Menu
{
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
        Console.SetCursorPosition(1,3);
        for (int i =0;i < 49; i++) {
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
        Console.SetCursorPosition(1,10);
        for (int i =0;i < 49; i++) {
            Console.Write("=");
        }
        CetakSamping(10);

        Console.SetCursorPosition(2, 11);
        Console.Write("Kembali");

        Console.SetCursorPosition(21, 11);
        Console.Write("Tampilkan");

        Console.SetCursorPosition(44, 11);
        Console.Write("Edit");

        //
        CetakBawah(12);
    }
}
