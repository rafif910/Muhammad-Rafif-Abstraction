﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAbstrak2726.AbstrakClass
{
    public class Asus : Laptop
    {
        public override void menyala()
        {
            Console.WriteLine("klik tombol power");
            Console.WriteLine("harus memiliki daya");
        }
    }
}