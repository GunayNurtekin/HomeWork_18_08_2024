namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
        //byte, short, int, ve long tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın. Bu değişkenlerin bellekte kapladıkları alanı sizeof() operatörünü kullanarak ekrana yazdırın

        byte bytevalue = 42;
        short shortvalue = 42;   
        int intvalue = 42;
        long longvalue = 42;

         Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
        Console.WriteLine($"Size of short: {sizeof(short)} bytes");
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of long: {sizeof(long)} bytes");
        Console.WriteLine($"sizeof operatörü ile elde edilen değerler sabittir ve değişkenin türüne bağlıdır, içeriğine (değerine) bağlı değildir.");

    }
}
