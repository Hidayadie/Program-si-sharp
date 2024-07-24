namespace Program_UAS;

public class Siswa : Orang
{
    public string Kelas;
    public string Jurusan;

    public Siswa(string Nama, string ID, string Kelas, string Jurusan) :
           base(Nama, ID)
    {
        this.Kelas = Kelas;
        this.Jurusan = Jurusan;
    }
}
