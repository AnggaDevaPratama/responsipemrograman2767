using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Nama : Angga Deva Pratama");
            Console.WriteLine("NIM  : 19.11.2767");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            Karyawan karyawan3 = new Karyawan();

            karyawan1.No = 1;
            karyawan1.Nik = 19112767;
            karyawan1.Nama = "Angga Deva Pratama";
            karyawan1.Gaji = 7000000;

            karyawan2.No = 2;
            karyawan2.Nik = 19112747;
            karyawan2.Nama = "Dizar Muhammad";
            karyawan2.Gaji = 5000000;

            karyawan3.No = 3;
            karyawan3.Nik = 19112787;
            karyawan3.Nama = "Romo Fauzi";
            karyawan3.Gaji = -900;

            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
            karyawan3.InfoKaryawan();
            Console.WriteLine("");
            Console.WriteLine("Mantap dapat kenaikan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            karyawan3.BonusGaji();
	}
	public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

       

        public void InfoKaryawan()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  / {1}/{2}/{3}        ", No, Nik, Nama, Gaji);
            
        }

        public void BonusGaji()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  / {1}/{2}/{3}        ", No, Nik, Nama, Gaji*0.1+Gaji);

        }


    }
}
