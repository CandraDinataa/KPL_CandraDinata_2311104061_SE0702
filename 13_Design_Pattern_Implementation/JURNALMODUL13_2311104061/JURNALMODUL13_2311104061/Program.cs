class Program
{
    static void Main(string[] args)
    {
        // A & B
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // C - Tambah anggota kelompok dan asisten
        data1.AddSebuahData("Candra");
        data1.AddSebuahData("Rafi");
        data1.AddSebuahData("Asisten: Andi");

        // D - Print dari data2
        Console.WriteLine("Data dari data2:");
        data2.PrintSemuaData();

        // E - Hapus nama asisten
        data2.HapusSebuahData(2); // Index ke-2 adalah "Asisten: Andi"

        // F - Print ulang dari data1 (cek apakah asisten terhapus)
        Console.WriteLine("\nSetelah penghapusan, data dari data1:");
        data1.PrintSemuaData();

        // G - Print jumlah data
        Console.WriteLine($"\nJumlah elemen data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah elemen data2: {data2.GetSemuaData().Count}");
    }
}
