using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

rekeningbank newrekenignbank = new rekeningbank("777");

string pilihan;
double jumlah;

while (true)
{
    Console.Clear();

    Console.WriteLine("selamat datang di atm ");
    Console.WriteLine("1. Display info");
    Console.WriteLine("2. Setor uang");
    Console.WriteLine("3. Tarik uang");
    Console.WriteLine("4. keluar");
    Console.Write("Pilihan anda: ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        newrekenignbank.displayinfo();
    }
    else if (pilihan == "2")
    {
        Console.Write("\nMasukkan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());

        newrekenignbank.setoruang(jumlah);
    }
    else if (pilihan == "3")
    {
        Console.Write("\nMasukkan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());

        newrekenignbank.Tarikuang(jumlah);
    }
    else if (pilihan == "4")
    {
        Console.WriteLine("terimak kasih telah menggunakan pelayanan atm kami");
        break;
    }
    else
    {
        Console.WriteLine("Pilihan anda tidak valid");
    }
    Console.ReadLine();
}
public class rekeningbank
{
    private double _saldo;
    private string _norekening;

    public double Saldo
    {
        get { return _saldo; }
        set
        {
            if (value >= 0) value = _saldo;
            else Console.WriteLine("Saldo tidak boleh negatif");
        }
    }
    public string norekening
    {
       get { return _norekening;  }
    }

    public rekeningbank (string norekening)
    {
        _saldo = 1000000;
        _norekening = norekening;
    }

    public void Tarikuang (double jumlah)
    {
        if (jumlah > 0)
        {
            if (Saldo >= jumlah)
            {
                Saldo -= jumlah;
                Console.WriteLine("Berhasil tarik uang");
            }
            else
            {
                Console.WriteLine("Saldo tidak cukup");
            }
        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
        
    }

    public void setoruang(double jumlah)
    {
        if (jumlah > 0)
        {
            Saldo += jumlah;
            Console.WriteLine("berhasil setor uang");
        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
    }

    public void displayinfo()
    {
        Console.WriteLine("\nDisplay info rekening");
        Console.WriteLine($"No rekening {norekening}");
        Console.WriteLine($"Saldo {Saldo}");
    }


}


