namespace Program_UAS;

public class EditOrang : Menu
{
    public EditOrang(int index)
    {
        Tampilkan();
        Console.ReadKey();
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
        Console.Write("Nama: ");
        CetakSamping(4);
        Console.Write("Nomor Induk: ");
        CetakSamping(5);
        Console.Write("Jenis Kelamin: ");
        CetakSamping(6);
        Console.Write("Nama: ");
        CetakSamping(7);
        CetakSamping(8);
        CetakSamping(9);
    }
}
