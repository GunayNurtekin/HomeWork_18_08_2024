namespace HomeWork07;

class Program
{
    static void Main(string[] args)
    {
        int buyuksayi= 1200500;
        byte kucuksayi = (byte)buyuksayi;
        int degerfarki = buyuksayi-kucuksayi;

        System.Console.WriteLine($"int türündeki sayı : {buyuksayi} iken byte türündeki sayı : {kucuksayi} oldu. Değer {degerfarki} kadar küçüldü.");
    }
}
