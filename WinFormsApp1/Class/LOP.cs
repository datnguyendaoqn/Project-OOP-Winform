using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DanhSach;

namespace WinFormsApp1.Class
{
    internal class LOP
    {
        private string malop;
        private string tenlop;
        private int year;
        public DSSV dssv = new DSSV();

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public int Year { get => year; set => year = value; }

    }
}
