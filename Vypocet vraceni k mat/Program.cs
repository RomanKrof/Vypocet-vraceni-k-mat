using System;

namespace Vypocet_vraceni_k_mat
{
    class Program
    {       
        static int[] mince = new int[] { 50, 20, 10, 5, 2, 1};
        static int[] hodnoty = new int[mince.Length];
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                int b;
                int c;

                Console.Write("Zadejte cenu zboží: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zadaná hodnota není číslo!");
                    break;
                }

                Console.Write("Zadejte platbu: ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zadaná hodnota není číslo!");
                    break;
                }

                c = b - a;

                if(c < 0)
                {
                    Console.WriteLine("Zaplatili jste méně, než to stojí");
                    break;
                }
               
                for (int i = 0; i < mince.Length; i++)
                {
                    hodnoty[i] = c / mince[i];
                    c = c % mince[i];
                }

                //int padesat;
                //int dvacet;
                //int deset;
                //int pet;
                //int dva;
                //int jedna;
                //int zbytek;

                //padesat = c / 50;
                //zbytek = c % 50;

                //dvacet = zbytek / 20;
                //zbytek = zbytek % 20;

                //deset = zbytek / 10;
                //zbytek = zbytek % 10;

                //pet = zbytek / 5;
                //zbytek = zbytek % 5;

                //dva = zbytek / 2;
                //zbytek = zbytek % 2;

                //jedna = zbytek / 1;
                //zbytek = zbytek % 1;

                //int vpadesat;
                //int vdvacet;
                //int vdeset;
                //int vpet;
                //int vdva;
                //int vjedna;

                Console.WriteLine($@"Cena zboží = {a}
Platba = {b}
Vrátíme: {hodnoty[0]} 50Kč 
         {hodnoty[1]} 20Kč 
         {hodnoty[2]} 10Kč 
         {hodnoty[3]} 5Kč 
         {hodnoty[4]} 2Kč 
         {hodnoty[5]} 1Kč");
                Console.ReadLine();
            }
        }

        //public void Vypis()
        //{
        //    if (padesat )
        //}
    }
}
