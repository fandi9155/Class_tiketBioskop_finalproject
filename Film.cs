using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject1
{
    class Film
    {
        int     kafir = 30000,   // ini adalah sebuah variabel integer
                 setan = 30000,
                 kunti  = 30000,
                 milea  = 30000,
                 horor,
                 romantic;


        public void InputData() //method yang hanya menjalankan sekumpulan perintah dan
            //tidak menghasilkan suatu nilai(Tetapi masih dapat menampilkan sesuatu ke layar)
        {
            Console.WriteLine("=============================="); //baris 19-30 untuk menampilkan menu pilihan pada program
            Console.WriteLine("=========BIOSKOP KAMI=========");
            Console.WriteLine("==============================");
            Console.WriteLine("\n");
            Console.WriteLine("  Daftar film yang tersedia  ");
            Console.WriteLine("==============================");
            Console.WriteLine("====== Kategori Horor ======");
            Console.WriteLine("" +
                "1. Kafir             : Rp30.000\n" +
                "2. Pengapdi Setan    : Rp30.000\n" +
                "3. Sunyi             : Rp30.000\n");

            Console.WriteLine(" ==== Kategori Romantis ====");
            Console.WriteLine("" +
                "1. Bucin            : Rp30.000\n" +
                "2. Mariposa         : Rp35.000. \n" +
                "3. Milea            : Rp.20000\n");

            char pilihan;  // berfungsi untuk menyimpan karakter
            Console.WriteLine("Tekan 'y' untuk melanjutkan Pilihan");
            pilihan = Convert.ToChar(Console.ReadLine());
            if (pilihan == 'y')
            {
                Console.WriteLine("pilih film horor yang akan di tonton[1,2,3]:");
                horor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pilih film romantis yang akan di tonton [1,2,3]:");
                romantic = Convert.ToInt32(Console.ReadLine());

                if (horor == 1 && romantic == 1)  //disiini menggunakan if else, apa bila kita memilih angka yang akan di masukan
                                                  // maka angka itu akan di pilih
                    Console.WriteLine(" Total harga pembayaran :{0}", kunti + milea);
                else if (horor == 2 && romantic == 1)
                    Console.WriteLine(" total harga pembayaran : {0}", setan + milea);
                else if (horor == 3 && romantic == 1)
                    Console.WriteLine(" total harga pembayaran : {0}", kafir + milea);
                else if (horor == 1 && romantic == 2)
                    Console.WriteLine(" total harga pembayaran : {0}", kunti + milea);
                else if (horor == 2 && romantic == 2)
                    Console.WriteLine(" total harga pembayaran : {0}", setan + milea);
                else if (horor == 3 && romantic == 2)
                    Console.WriteLine(" total harga pembayaran : {0}", kafir + milea);
                else if (horor == 1 && romantic == 3)
                    Console.WriteLine(" total harga pembayaran : {0}", kunti + milea);
                else if (horor == 2 && romantic == 3)
                    Console.WriteLine(" total harga pembayaran : {0}", setan + milea);
                else if (horor == 3 && romantic == 3)
                    Console.WriteLine("total harga pembayaran  : {0}", kafir + milea);
              
                else

                    Console.WriteLine(" Maaf film tidak tersedia "); //jika kita memasukan angka yang tidak terdaftar maka else ini akan di lajankan

            }
        }
    }
}
