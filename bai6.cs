using System;
using System.Collections.Generic;
using System.Text;
class bai6
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
        List<int> numbers = new List<int> { 6, 2, 3, 8, 5, 4, 1, 7 };
        Console.WriteLine("Danh sach so nguyen :");
        foreach (var p in numbers)
        {
            Console.Write($"{p} ");
        }
        int dem = numbers.Count(x => x%2==0);
        Console.WriteLine($"\nSo luong so chan : {dem}");
    }
}
