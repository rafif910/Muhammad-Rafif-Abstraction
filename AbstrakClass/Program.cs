using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasAbstrak2726.AbstrakClass
namespace TugasAbstrak2726
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop;
            laptop = new Lenovo();
            laptop.menyala();
            Console.WriteLine();
            laptop = new Asus();
            laptop.menyala();
            Console.ReadKey();

        }
    }
}