﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program_UAS;

namespace Utama
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Menu menu;
            menu = new Dashboard();
            menu.Tampilkan();
            menu.Inputan();

        }
    }
}