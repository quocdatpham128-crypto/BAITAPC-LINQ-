using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class bai3
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
        List<int> numbers = new List<int>() { 6, 2, 3, 8, 5, 4, 1, 7 };
        Console.WriteLine("Danh sach so nguyen :");
        foreach (var p in numbers)
        {
            Console.Write($"{p} ");
        }
        Console.WriteLine("\nDanh sach so nguyen sau khi sap xep :");
        var sochan = numbers.OrderBy(p => p);
        foreach (var p in sochan)
        {
            Console.Write($"{p} ");
        }
    }
}
