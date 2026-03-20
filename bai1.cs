using System;
using System.Collections.Generic;
using System.Text;
class bai1
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
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach so nguyen :");
        foreach  (var p in numbers)
        {
            Console.Write($"{p} ");
        }
        Console.WriteLine("\nCac so chan trong danh sach :");
        var sochan = numbers.Where(p => p % 2 == 0);
        foreach ( var p in sochan)
        {
            Console.Write($"{p} ");
        }
    }
}
