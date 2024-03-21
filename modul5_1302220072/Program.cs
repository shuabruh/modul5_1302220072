internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan objPenjumlahan = new Penjumlahan();
        Console.WriteLine(objPenjumlahan.jumlahTigaAngka<float>((float)1.2, (float)5.5, (float)1.4));

        SimpleDataBase<float> db = new SimpleDataBase<float>();
        db.addNewData((float)19.22);
        db.printAllData();
    }

    public class Penjumlahan
    {
        public T jumlahTigaAngka<T>(T a, T b, T c)
        {
            return (dynamic)a + (dynamic)b + (dynamic)c;
        }
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}