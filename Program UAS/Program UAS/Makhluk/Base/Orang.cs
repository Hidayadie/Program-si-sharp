namespace Program_UAS;

public abstract class Orang : InterfaceOrang
{
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
        throw new NotImplementedException();
    }

    public virtual void UbahData()
    {
        throw new NotImplementedException();
    }
}
