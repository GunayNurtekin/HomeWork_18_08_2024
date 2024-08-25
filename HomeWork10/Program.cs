namespace HomeWork10;

class Program
{
    static void Main(string[] args)
    {

//int tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp double tipinde bir değişkene atayın ve sonucu ekrana yazdırın.

       int sayi1 = 5;
       int sayi2 =10;
       int sayi3 =15;
       double ortalama = (sayi1+sayi2+sayi3)/3;

       System.Console.WriteLine($"3 sayının ortalaması : {ortalama}");

    }
}
