using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}
class bai14
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
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 }
        };
        bool kt = students.Any(x => x.Score < 5);
        if (kt)
        { Console.WriteLine("co sinh bi rot"); }
        else
            { Console.WriteLine("khong co sinh bi rot"); 
        }
    }
}

