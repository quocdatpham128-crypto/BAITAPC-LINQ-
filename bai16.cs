using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class bai16
{
    static void GT()
    {
        Console.WriteLine("Pham Quoc Dat");
        Console.WriteLine("2415053122205");
        Console.WriteLine("----------------------------");
        Console.WriteLine("\n\n");
    }
    static void Main(string[] args)
    {
        GT();
        List<int> ds = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        int tong = ds.Sum();
        Console.WriteLine($"Tong: {tong} ");
    }
}

