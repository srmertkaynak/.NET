using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1
            //Console.WriteLine("Hello World!");
            #endregion

            #region Ders 2
            /*Console.Write("Benim Adım: ");
            Console.WriteLine("Mert");
            Console.Read(); // Enter tuşuna basınca devam et.
            // Herhangi bir tuşa basınca devam et. Console.ReadKey();
            Console.Write("Soyadım: ");
            Console.WriteLine("Kaynak");*/
            #endregion

            #region Ders 3
            /*
     * İsminiz ne? diye sorulacak. Aynı satıra adı yazılacak. 
     * bir alt satıra geçilecek. Soyadınız ne? ne diye sorulacak. Ve aynı satıra yazılacak.
     * bir alt satıra inilerek ekranda iyi günler yazılacak.

    Console.Write("İsminiz ne?: ");
    String ad = Console.ReadLine(); // Konsoldan kullanıcıdan veri alma
    Console.Write("Soyadınız ne?: ");
    String soyad = Console.ReadLine();
    Console.WriteLine("İyi günler, "+ad+" "+soyad);
    */
            #endregion

            #region Değişkenler
            /*char first = 'a';
            byte test = 255;
            int number = 444;
            float test2 = 11.4F;
            double test4 = 11.4;
            decimal des = 15.8M;
            bool test5 = true;*/
            #endregion

            #region Aritmetik Operatörler
            // Aritmetik Operatörler

            /*int number = 4 + 7;
            Console.WriteLine(number);*/

            /* Kısa ve Uzun Kenarı Verilen Dikdörtgenin alanını hesaplama

            int longEdge = 10;
            int shortEdge = 5;
            Console.WriteLine(longEdge * shortEdge); */

            /*int number = 7 % 2;
            Console.WriteLine(number);*/
            #endregion

            #region Tip Dönüşümleri
            /* Tip Dönüşümleri
    int numberInt = 10;
    string numberString = numberInt.ToString();
    int numberInt2 = Convert.ToInt32(numberString);
    // ToInt16 = short
    // ToInt32 = int
    // ToInt64 = float
    double numberDouble = Convert.ToDouble(numberString);
    Console.WriteLine(numberDouble);

    // Konsol üzerinden küçük kenarı ve büyük kenarı girilen dikdörtgenin çevresini hesaplayan uygulamayı yazınız.

    Console.WriteLine("Enter Short Edge: ");
    int shortEdge = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Long Edge: ");
    int longEdge = Convert.ToInt32(Console.ReadLine());
    string cevre = ((shortEdge + longEdge) * 2).ToString();
    Console.Write(cevre);

    */
            #endregion

            #region Hata Yönetimi

            try
            {
                Console.WriteLine("1.Sayıyı giriniz: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayıyı giriniz: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number1 / number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Burası son durak.");
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            #endregion

        }
    }
}
