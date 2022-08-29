internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);

        int sıcaklık =32;
        if(sıcaklık <= (int)HavaDurumu.Normal)
            Console.WriteLine("Havanın ısnmasını bekle");
        else if(sıcaklık>=(int)HavaDurumu.Sıcak)
            Console.WriteLine("Havan Sıcak");  
        else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık>=(int)HavaDurumu.CokSıcak)
            Console.WriteLine("dışarı çıkalım");
    }
}
enum Gunler
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}
enum HavaDurumu
{
    Soğuk =5,
    Normal=20,
    Sıcak = 25,
    CokSıcak = 30
}