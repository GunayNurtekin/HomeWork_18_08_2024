namespace HomeWork13;

class Program
{
    static void Main(string[] args)
    {

        //long tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi. Bu değeri int tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        
        long veryBig = 5234225234234323334;

        int notBig = (int)veryBig;

        System.Console.WriteLine($"Long veri tipinde : {veryBig} olan sayi , int veri tipinde : {notBig} değerine dönüşür.");
        System.Console.WriteLine("Ciddi oranda veri kaybı yaşanır.");
    }
}
