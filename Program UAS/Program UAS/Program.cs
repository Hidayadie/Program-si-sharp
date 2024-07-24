using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Program_UAS;
namespace Utama
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Menu menu;

            Database.LoadSiswa("data.txt");
            menu = new Login();

        }
    }
}