namespace Program_UAS;

public abstract class Orang : InterfaceOrang
{
    private protected string Nama;
    private protected string ID;
    private protected string JenisKelamin = "";
    private protected string TanggalLahir = "";
    private protected string Alamat = "";
    private protected string NoHP = "";
    private protected string Email = "";

    public Orang(string Nama, string ID)
    {
        this.Nama = Nama;
        this.ID = ID;
    }
    public virtual void Tampilkan()
    {
        throw new NotImplementedException();
    }

    public virtual void UbahData()
    {
        throw new NotImplementedException();
    }
}
