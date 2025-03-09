class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine("Kode Pos " + kelurahan + ": " + KodePos.GetKodePos(kelurahan));

        DoorMachine door = new DoorMachine();

        Console.WriteLine("\nMensimulasikan perubahan state:");
        door.Unlock(); // Mengubah ke Terbuka
        door.Lock();   // Mengubah ke Terkunci
        door.Unlock(); // Mengubah ke Terbuka
        door.Lock();   // Mengubah ke Terkunci
    }
}
