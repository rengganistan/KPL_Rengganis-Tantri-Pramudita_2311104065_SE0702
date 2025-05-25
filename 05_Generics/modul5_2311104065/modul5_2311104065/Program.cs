using modul5_2311104065;

class Program
{
    static void Main(string[] args)
    {
        // === Input angka dari NIM ===
        // NIM kamu: 2311104065 → ambil tiga dua-digit angka: 11, 04, 06
        // Karena NIM berakhiran 5 → gunakan tipe data double
        double angka1 = 11;
        double angka2 = 4;
        double angka3 = 6;

        // Panggil method generic
        Penjumlahan penjumlahan = new Penjumlahan();
        double hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine("=== Hasil Penjumlahan Generic Method ===");
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}