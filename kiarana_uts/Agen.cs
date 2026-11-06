using System;

namespace kiarana_uts
{
    class Agen
    {
        static void Main()
        {

            Console.WriteLine("===== Class, Object, Attribute, dan Method ======");
            string idAgen = "agen";
            string namaAgen1 = "Cinta";
            string namaAgen2 = "kirana";
            int stokAgen1 = 100;
            int stokAgen2 = 50;

            string idProduk = "idGalon";
            string namaProduk = "Galon";
            int stokGudang = 500;

            int GalonAkua = 20000;
            int GalonBerkeran = 12000;

            Console.WriteLine("idAgen:" + idAgen);
            Console.WriteLine("Siapakah nama agen1: " + namaAgen1);
            Console.WriteLine("Siapakah nama agen2: " + namaAgen2);
            Console.WriteLine("Berapa Stok agen1: " + stokAgen1);
            Console.WriteLine("Berapa Stok agen2: " + stokAgen2);

            Console.WriteLine("===== Produk Galon =====");
            Console.WriteLine("id produk:" + idProduk);
            Console.WriteLine("Jumlah Stok Gudang:" + stokGudang);

            Console.WriteLine("===== Biaya Galon =====");
            Console.WriteLine("Harga Galon Akua:" + GalonAkua);
            Console.WriteLine("Harga Galon Berkeran:" + GalonBerkeran);


        }

        private static void TampilanInfo()
        {
            throw new NotImplementedException();
        }


    }
}
    
   








