namespace Program_UAS;

public static class Database
{
    public static List<Orang> orang = new List<Orang>();

    public static void LoadSiswa(string file)
    {

        using (StreamReader baca = new StreamReader(file))
        {
            string line;
            while ((line = baca.ReadLine()) != null)
            {
                string[] pecahan = line.Split(',');
                if (pecahan.Length == 9)
                {
                    Siswa siswa = new Siswa(pecahan[0], pecahan[1], pecahan[2], 
                                            pecahan[3], pecahan[4], pecahan[5],
                                            pecahan[6], pecahan[7], pecahan[8]);
                    orang.Add(siswa);
                }
            }
        }

    }
    public static void SaveSiswa(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Siswa siswas in orang)
            {
                writer.WriteLine(siswas.Nama            + ',' + 
                                 siswas.ID              + ',' + 
                                 siswas.Status          + ',' + 
                                 siswas.JenisKelamin    + ',' +
                                 siswas.Kelas           + ',' +
                                 siswas.Jurusan         + ',' +
                                 siswas.Alamat          + ',' +
                                 siswas.Email           + ',' +
                                 siswas.NoHP            );
            }
        }
    }

}
