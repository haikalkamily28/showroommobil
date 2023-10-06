using System;
using System.Diagnostics.Metrics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Merk Merk = new Merk();
        Merk.setMerk();


    }
}
abstract class Showroom
{

    protected string merk;
    public abstract void desc_class();

}

interface Action
{
    void daftar_pustaka()
    {

    }
}
class Merk : Showroom, Action
{
    public void setMerk()
    {
        Console.WriteLine("Pilih merk Mobil :");
        Console.WriteLine("1. Toyota");
        Console.WriteLine("2. Daihatsu");
        Console.WriteLine("3. Suzuki");
        Console.WriteLine("4. Honda");
        Console.WriteLine("\nMobil yang dipilih: ");
        int pilih = int.Parse(Console.ReadLine());
        if (pilih == 1)
        {
            this.merk = "Toyota";
        }
        else if (pilih == 2)
        {
            this.merk = "Daihatsu";
        }
        else if (pilih == 3)
        {
            this.merk = "Suzuki";
        }
        else if (pilih == 4)
        {
            this.merk = "Honda";
        }
        else
        {
            Console.WriteLine("Kami tidak menjual merk mobil tersebut");

        }
        desc_class();
    }
    public void getMerk()
    {
        Console.WriteLine($"Merk Mobil {this.merk}");
    }
    public override void desc_class()
    {
        type Type = new type();

        Console.Clear();
        if (this.merk == "Toyota")
        {
            getMerk();
            Console.WriteLine();
            Console.WriteLine("Toyota adalah sebuah perusahaan otomotif asal Jepang yang merupakan salah satu produsen mobil terbesar dan terkenal di dunia. Perusahaan ini didirikan pada tahun 1937 oleh Kiichiro Toyoda sebagai cabang bisnis otomotif dari perusahaan induknya, Toyota Industries. Nama \"Toyota\" dipilih sebagai penghormatan kepada Kiichiro Toyoda dan juga karena pengucapannya yang lebih mudah daripada \"Toyoda.\"");
            Type.toyota();
        }
        else if (this.merk == "Daihatsu")
        {
            getMerk();
            Console.WriteLine();
            Console.WriteLine("Daihatsu adalah sebuah produsen otomotif asal Jepang yang merupakan anak perusahaan dari Toyota Motor Corporation. Daihatsu terkenal karena memproduksi mobil-mobil kecil, city cars, dan kendaraan kompak lainnya. Perusahaan ini didirikan pada tahun 1907 di Jepang dan menjadi salah satu produsen mobil tertua di negara tersebut.");
            Type.daihatsu();
        }
        else if (this.merk == "Suzuki")
        {
            getMerk();
            Console.WriteLine();
            Console.WriteLine("Suzuki Corporation, atau lebih dikenal dengan nama Suzuki, adalah sebuah produsen otomotif dan perusahaan multinasional asal Jepang yang bermarkas di Hamamatsu, Jepang. Suzuki dikenal karena memproduksi berbagai jenis kendaraan, termasuk mobil, sepeda motor, mesin luar, dan sepeda.");
            Type.suzuki();
        }
        else if (this.merk == "Honda")
        {
            getMerk();
            Console.WriteLine();
            Console.WriteLine("Honda adalah sebuah perusahaan otomotif dan produsen sepeda motor multinasional asal Jepang yang terkenal di seluruh dunia. Perusahaan ini didirikan pada tahun 1948 oleh Soichiro Honda dan Takeo Fujisawa. Honda dikenal karena produk-produknya yang mencakup mobil penumpang, sepeda motor, mesin pemotong rumput, mesin luar, dan berbagai jenis kendaraan dan mesin lainnya.");
            Type.honda();
        }
        Console.WriteLine("\nlanjut ke pilihan mobil kami");
        Console.WriteLine("apakah lanjut? *ya,no[y/n]");
        string pilih = Console.ReadLine();
        if (pilih == "y")
        {
            Console.Clear();
        }
        else if (pilih == "n")
        {
            Console.Clear();
            thanksCard();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("inputan tidak valid");
            Console.WriteLine();
            desc_class();
        }
    }
    public void thanksCard()
    {
        Console.WriteLine("terimakasih telah mengunjungi showroom kami");
        Console.ReadLine();
        Environment.Exit(0);
    }
}


class type : Action
{

    public void toyota()
    {
        Console.WriteLine("Pilihan Mobil Toyota");
        Console.WriteLine("1. Avanza");
        Console.WriteLine("2. Kijang Innova");
        Console.WriteLine("3. Alphard");
        Console.WriteLine("\nMobil apa yang ingin kamu lihat ?");
        int tampil = int.Parse(Console.ReadLine());
        if (tampil == 1)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("avanza", "Rp120.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("avanza", "mobil keluarga, muat 8 penumpang, dan irit bahan bakar", "Rp120.000.000");
            }
        }
        else if (tampil == 2)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("Kijang innova", "Rp320.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("Kijang innova", "mobil keluarga, muat 8 penumpang, cocok untuk perjalanan jauh dengan akselerasi luar biasa", "Rp320.000.000");
            }

        }
        else if (tampil == 3)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("alphard", "Rp1.000.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("alphard", "mobil mewwah, muat 7 penumpang, dengan tingkat kenyamanan penumpang yang tinggi", "Rp1.000.000.000");
            }
        }
        else
        {
            Console.WriteLine("pilih lagi");
            toyota();
        }
    }
    public void daihatsu()
    {
        Console.WriteLine("Pilihan Mobil Daihatsu");
        Console.WriteLine("1. Xenia");
        Console.WriteLine("2. Terios");
        Console.WriteLine("3. GranMax");
        Console.WriteLine("\nMobil apa yang ingin kamu lihat ?");
        int tampil = int.Parse(Console.ReadLine());
        if (tampil == 1)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("xenia", "Rp120.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("xenia", "mobil keluarga, muat 7-8 penumpang, dan merupakan saingan dari avanza", "Rp120.000.000");
            }
        }
        else if (tampil == 2)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("terios", "Rp320.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("terios", "mobil Keluarga, muat 7-8 penumpang, dengan desain futuristik yang menggoda mata", "Rp320.000.000");
            }

        }
        else if (tampil == 3)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("GranMax", "Rp1.000.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("GranMax", "mobil mewah, muat 7 orang, dengan interior mewah dan cocok untuk mengantar paket", "Rp1.000.000.000");
            }
        }
        else
        {
            Console.WriteLine("pilih lagi");
            daihatsu();
        }
    }
    public void suzuki()
    {
        Console.WriteLine("Pilihan Mobil Suzuki");
        Console.WriteLine("1. ertiga");
        Console.WriteLine("2. baleno");
        Console.WriteLine("3. jimny");
        Console.WriteLine("\nMobil apa yang ingin kamu lihat ?");
        int tampil = int.Parse(Console.ReadLine());
        if (tampil == 1)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("ertiga", "Rp190.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("ertiga", "mobil keluarga dengan harga terjangkau, hemat bahan bakar, nyaman buat perjalanan jauh ", "Rp120.000.000");
            }
        }
        else if (tampil == 2)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("Baleno", "Rp320.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("Baleno", "mobil Hatchback, ukuran tidak begitu besar, interior futuristik dengan selera anak muda", "Rp320.000.000");
            }

        }
        else if (tampil == 3)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("Jimny", "Rp190.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("Jimny", "mobil Offroad, susah dicari di Indonesia, cocok untuk orang yang suka mendaki gunung  ", "Rp400.000.000");

            }
        }
        else
        {
            Console.WriteLine("pilih lagi");
            suzuki();
        }
    }
    public void honda()
    {
        Console.WriteLine("Pilihan Mobil Honda");
        Console.WriteLine("1. jazz");
        Console.WriteLine("2. civic");
        Console.WriteLine("3. mobilio");
        Console.WriteLine("\nMobil apa yang ingin kamu lihat ?");
        int tampil = int.Parse(Console.ReadLine());
        if (tampil == 1)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("jazz", "Rp120.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("jazz", "mobil cocok untuk anak muda, ukuran compact, lincah dan gesit", "Rp120.000.000");
            }
        }
        else if (tampil == 2)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("civic", "Rp320.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("civic", "mobil sedan, akselerasi kencang, interior futuristik", "Rp320.000.000");
            }

        }
        else if (tampil == 3)
        {
            Console.WriteLine("\nTampilkan hanya 1.harga atau 2.deskripsi & harga? [1 / 2]\"");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                TampilInfoMobil("mobilio", "Rp400.000.000");
            }
            else if (input == 2)
            {
                TampilInfoMobil("mobilio", "mobil cocok untuk keluarga, harga terjangkau, cocok untuk perjalanan jauh  ", "Rp400.000.000");

            }
        }
        else
        {
            Console.WriteLine("pilih lagi");
            honda();
        }
    }
    public void TampilInfoMobil(string type, string harga)
    {
        Console.WriteLine($"Mobil: {type} \nHarga: {harga}");
        Console.WriteLine("\ntutup aplikasi");
        Console.WriteLine("[y]");
        string pilih = Console.ReadLine();
        if (pilih == "y")
        {
            Console.Clear();
            ThanksCard();
        }


    }

    public void TampilInfoMobil(string type, string deskripsi, string harga)
    {
        Console.WriteLine($"Mobil: {type} \nDeksripsi: {deskripsi} \nHarga: {harga}");
        Console.WriteLine("\ntutup aplikasi");
        Console.WriteLine("[y]");
        string pilih = Console.ReadLine();
        if (pilih == "y")
        {
            Console.Clear();
            ThanksCard();
        }
    }

    public void ThanksCard()
    {
        Console.WriteLine("Terima Kasih Telah mengunjungi showroom kami");
        Console.ReadLine();
        Environment.Exit(0);
    }
}