namespace Program_UAS;

public class Siswa : Orang
{
    public string Kelas;
    public string Jurusan;

    public Siswa(string Nama        , string ID     , string Status , 
                 string JenisKelamin, string Kelas  , string Jurusan, 
                 string Alamat      , string Email  , string NoHP   ) :
           base(Nama, ID)
    {
        this.Kelas = Kelas;
        this.Jurusan = Jurusan;
        this.Status = "Siswa Aktif";
    }

    public override void Tampilkan()
    {
        base.Tampilkan();
        Console.SetCursorPosition(19, 7);
        Console.Write(this.Kelas);
        Console.SetCursorPosition(19, 8);
        Console.Write(this.Jurusan);
    }
}
