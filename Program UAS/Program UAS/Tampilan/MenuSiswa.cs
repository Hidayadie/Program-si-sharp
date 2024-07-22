namespace Program_UAS;

public class Siswa : Menu
{
    public override void Tampilkan()
    {

        Console.Clear();
        CetakAtas("WARGA SEKOLAH");
        //

        CetakSamping(1);
        Console.Write("Database individu yang terdaftar di SMA Kayangan");

        CetakSamping(2);
        Console.Write("Database siswa SMA Kayangan");

        CetakSamping(3);
        Console.Write("Jml ");
        //
        CetakBawah(6);
    }
}
