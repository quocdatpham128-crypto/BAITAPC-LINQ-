using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
class bai7
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
        List<int> numbers = new List<int> { 2, 6, 3, 8, 5, 4, 1, 7 };
        Console.WriteLine("Danh sach so nguyen :");
        foreach (var p in numbers)
        {
            Console.Write($"{p} ");
        }
        int dem = numbers.Count(x => x>10);
        if (dem != 0) Console.WriteLine("\nDanh sach co so lon hon 10");
        else Console.WriteLine("\n Danh sach khon co so lon hon 10");
    }
}
