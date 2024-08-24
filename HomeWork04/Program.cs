namespace HomeWork04;

class Program
{
    static void Main(string[] args)
    {
    char character = 'b'; // Char tipinde bir değişken oluşturup içine bir harf atıyoruz.
    
    int asciiValue = (int)character; // Char tipindeki değişkenin ASCII değerini int tipindeki bir değişkene atıyoruz.

    Console.WriteLine($"'{character}' harfinin ASCII değeri: {asciiValue}"); // ASCII değerini ekrana yazdırıyoruz.
    }
}
