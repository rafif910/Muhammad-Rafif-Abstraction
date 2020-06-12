using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAbstrak2726.Interface
{
    public class Lenovo : ILaptop
    {
        public void menyala()
        {
            Console.WriteLine("klik tombol power");
            Console.WriteLine("harus memiliki daya");
        }
    }
}