using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAlgo
{
    internal class Program
    {
      
            //deklrasi array int dengan ukuran 30
        private readonly int[] a = new int[30];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void Read()
        {
            //menrima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("_________________________________");
            Console.WriteLine("Element array yang telah disusun");
            Console.WriteLine("_________________________________");
            for (int nn = 0; nn < n; nn++)
            {
                Console.WriteLine(a[nn]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // For n - 2passes
            {
                //Pada pas i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int nn = 0; nn < n - i; nn++)
                {
                    if (a[nn] < a[nn + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[nn];
                        a[nn] = a[ nn + 1];
                        a[nn + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the bubbleShort class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.Read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan apa saja untuk keluar.");
            Console.Read();
        }
    }
}


