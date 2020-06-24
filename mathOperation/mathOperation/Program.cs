using System;

namespace mathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int angka1 = 8;
                int angka2 = -2;
                int hasil_kali = fn_perkalian(angka1, angka2);
                Console.WriteLine($"Hasil perkalian {angka1} dan {angka2} = {hasil_kali}");

                int angka = -8;
                int pangkat = 1;
                int hasil_pangkat = fn_pangkat(angka, pangkat);
                Console.WriteLine($"Hasil {angka} di pangkat {pangkat} = {hasil_pangkat}");

                int faktor = 2;
                int hasil_faktorial = fn_faktorial(faktor);
                Console.WriteLine($"Hasil faktorial dari {faktor} = {hasil_faktorial}");

                int faktor1 = 4;
                int faktor2 = 2;
                int hasil_permutasi = fn_permutasi(faktor1, faktor2);
                Console.WriteLine($"Hasil dari P({faktor1},{faktor2}) = {hasil_permutasi}");

                //int angka_kombinasi1 = 4;
                //int angka_kombinasi2 = 2;
                int hasil_kombinasi = fn_kombinasi(faktor1, faktor2);
                Console.WriteLine($"Hasil dari C({faktor1},{faktor2}) = {hasil_kombinasi}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            
        }

        
        public static int fn_perkalian(int angka1, int angka2)
        {
            
            int kali_minus = 1;
            
            if (angka2 < 0) {
                angka2 = -angka2;
                kali_minus = -1;
            }
            
            int hasil = 0;
            /*
            if (angka2 < 0)
            {
                return -Multiple(angka1, -angka2);
            }

            if (angka1 < 0)
            {

                return -Multiple(-angka1, angka2);
            }
            */
            for (int i = 1; i <= angka2; i++)
            {
                hasil = hasil + angka1;
            }

            if (kali_minus > 0 )
            {
                return hasil;
            }

            return -hasil;

            //return 0
        }

        public static int fn_pangkat(int angka, int pangkat)
        {
            int hasil = 1;

            for (int i = 1; i <= pangkat; i++)
            {
                hasil = fn_perkalian(hasil,angka);
            }

            return hasil;
        }

        public static int fn_faktorial(int angka)
        {
            int hasil = 1;
            for (int i = 1; i <= angka; i++)
            {
                hasil = fn_perkalian(hasil, i);
            }

            return hasil;
        }

        public static int fn_permutasi(int angka1, int angka2)
        {
           if (angka1 == 0 && angka2 == 0)
                throw new System.DivideByZeroException();
            return fn_faktorial(angka1) / fn_faktorial(angka1 - angka2);

        }

        public static int fn_kombinasi(int angka1, int angka2) => fn_faktorial(angka1) / fn_perkalian(fn_faktorial(angka2),fn_faktorial(angka1 - angka2));

    }
}
