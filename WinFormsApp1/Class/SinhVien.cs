using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Class
{
    internal class SinhVien
    {
        private string masv;
        private string ho;
        private string ten;
        private bool phai;
        private string sdt;

        public string Masv { get => masv; set => masv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public bool Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
