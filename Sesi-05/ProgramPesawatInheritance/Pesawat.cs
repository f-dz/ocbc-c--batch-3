using System;

namespace ProgramPesawatInheritance
{
    public class Pesawat
    {
        public string nama;
        private string ketinggian;
        private string jumlahPenumpang;
        private int jumlahRoda;

        public string Ketinggian
        {
            get { return ketinggian;}
            set { ketinggian = value;}
        }

        public string JumlahPenumpang
        {
            get { return jumlahPenumpang;}
            set { jumlahPenumpang = value;}
        }

        public int JumlahRoda
        {
            get { return jumlahRoda;}
            set { jumlahRoda = value;}
        }

        public void Terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
        }

        public class PesawatTempur:Pesawat
        {
            public void TerbangTinggi()
            {
                Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1},sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanya {3} akan meledakkan senjata",
                    this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
            }
        }
    }
}