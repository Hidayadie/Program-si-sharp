namespace Program_UAS;

public class Siswa : Orang
{
    private string Kelas;
    private string Jurusan;

    public Siswa(string Nama, string ID, string Kelas, string Jurusan) :
           base(Nama, ID)
    {
        this.Kelas = Kelas;
        this.Jurusan = Jurusan;
    }
}
