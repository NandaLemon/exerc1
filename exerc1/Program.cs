using System;


namespace exerc1
{
    class Program
    {
        private int[] a = new int[37];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("masukkan banyaknya elemen array: ");
                string s = Console.ReadLine();
                n = Int32. Parse(s);
                if (n <= 37  )
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 37 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("--------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("elemen array yang telah tersusun");
            Console.WriteLine("-----------------------");
            for(int r = 0; r < n; r++)
            {
                Console.WriteLine(a[r]);
            }
            Console.WriteLine("");
        }
        public void Ujicoba1()
        {
            for (int i = 0; i < n; i++)
            {
                for(int r =0; r < n; r++)
                {
                    if (a[r] > a[r + 1])
                    {
                        int temp;
                        temp = a[r];
                        a[r] = a[r + 1];
                        a[r + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            mylist.read();
            mylist.Ujicoba1();
            mylist.display();
            Console.WriteLine("\n\n Tekan tombol apa saka untuk keluar. ");
            Console.Read();
        }
    }
}
