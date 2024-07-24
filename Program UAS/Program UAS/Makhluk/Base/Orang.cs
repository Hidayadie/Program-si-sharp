namespace Program_UAS;

public abstract class Orang : InterfaceOrang
{
    public string Status = "";
    public string JenisKelamin = "";
    public string ID;
    public string Nama;
    public string TanggalLahir = "";
    public string Alamat = "";
    public string NoHP = "";
    public string Email = "";

    public Orang(string Nama, string ID)
    {
        this.Nama = Nama;
        this.ID = ID;
    }
    public virtual void Tampilkan()
    {
        Console.SetCursorPosition(19, 3);
        Console.Write(this.Nama);
        Console.SetCursorPosition(19, 4);
        Console.Write(this.ID);
        Console.SetCursorPosition(19, 5);
        Console.Write(this.JenisKelamin);
        Console.SetCursorPosition(19, 6);
        Console.Write(this.Status);
    }

    public virtual void UbahData()
    {
        throw new NotImplementedException();
    }
}
