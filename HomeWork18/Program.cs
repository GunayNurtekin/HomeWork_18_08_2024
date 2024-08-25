namespace HomeWork18;

class Program
{
    static void Main(string[] args)
    {
        //string tipinde bir değişken oluşturun ve içine bir cümle yazın. Bu cümlenin karakter sayısını int tipinde bir değişkene atayıp ekrana yazdırın. (İpucu: .Length özelliğini kullanabilirsiniz, araştırın.)

        string sentences = "Acun Medya Akademi BackEnd Online Yazılım Eğitimi 2.hafta ödevleri";
        int numberofword = sentences.Length;

        System.Console.WriteLine($"Örnek Cümlemiz : {sentences}");
        System.Console.WriteLine($"Cümledeki toplam karakter sayısı : {numberofword}");
    }
}


