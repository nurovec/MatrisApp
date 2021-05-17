using System;
using System.Collections.Generic;

namespace MatrisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Random Matris ## \r\n");

            int enBuyuk, enKucuk = 0; 

            int miktar = 8;
            int[,] matris = new int[miktar, miktar]; //8 ,8 
            Random random = new Random();
            List<int> matristekisayilar = new List<int>();
            for (int x = 0; x < miktar; x++)
            {
                for (int y = 0; y < miktar; y++)
                {
                    int randomSayi = random.Next(1000, 9999);
                    matris[x, y] = randomSayi;
                    matristekisayilar.Add(randomSayi);
                    Console.Write(matris[x, y] + " ");
                }
                Console.WriteLine();
            }

            matristekisayilar.Sort(); //sayıları küçükten büyüğe sıraladık.
            enKucuk = matristekisayilar[0];
            enBuyuk = matristekisayilar[matristekisayilar.Count - 1];
             
            Console.WriteLine("\r\n ## Küçükten Büyüğe ## \r\n"); 

            MatrisGibiYaz(matristekisayilar, miktar, miktar);

            Console.WriteLine("");

            matristekisayilar.Reverse(); // 0 1 2 3 4 5 6 7 8  --  8 7 6 5 4 3 2 1 0 || 1 8 6 3 2 -- 2 3 6 8 1

            Console.WriteLine("## Büyükten Küçüğe ## \r\n"); 

            MatrisGibiYaz(matristekisayilar, miktar, miktar);

            Console.WriteLine($"\r\n En Büyük :{enBuyuk}");
            Console.WriteLine($"\r\n En Küçük :{enKucuk}");

            Console.ReadKey();
        }

        public static void MatrisGibiYaz(List<int> list,int X,int Y)
        {
            for (int xs = 0; xs < X; xs++)
            {
                for (int ys = 0; ys < Y; ys++)
                {
                    Console.Write(list[xs * X + ys] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
