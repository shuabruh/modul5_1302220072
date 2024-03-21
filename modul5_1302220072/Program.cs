internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan objPenjumlahan = new Penjumlahan();
        Console.WriteLine(objPenjumlahan.jumlahTigaAngka<float>((float)1.2, (float)5.5, (float)1.4));
    }

    public class Penjumlahan
    {
        public T jumlahTigaAngka<T>(T a, T b, T c)
        {
            return (dynamic)a + (dynamic)b + (dynamic)c;
        }
    }
}