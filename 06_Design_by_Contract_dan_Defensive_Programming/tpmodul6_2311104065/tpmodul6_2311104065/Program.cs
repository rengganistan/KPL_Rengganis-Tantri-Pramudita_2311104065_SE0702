using tpmodul6_2311104065;
class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rengganis");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();

        // Menunggu input user agar console tidak langsung tertutup
        Console.WriteLine("Tekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}