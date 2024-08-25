namespace HomeWork12;

class Program
{
    static void Main(string[] args)
    {
        //float tipinde bir değişken oluşturun ve içine 1.23f değerini atayın. Bu değeri double tipine dönüştürüp yeni bir değişkene atayın. İki değeri de ekrana yazdırıp karşılaştırın.
        
        float sayi= 1.23f;
        double yenisayi = (double)sayi;

        System.Console.WriteLine($"Float değerindeki sayi {sayi}");
        System.Console.WriteLine($"Double değerindeki sayi {yenisayi}");
        System.Console.WriteLine("Double değerindeki sayida hassasiyet daha fazladır.");
    }
}
