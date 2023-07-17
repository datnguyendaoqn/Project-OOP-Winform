using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Class;
using WinFormsApp1.DanhSach;

namespace WinFormsApp1
{
    public partial class fSVinput : Form
    {
        public fSVinput()
        {
            InitializeComponent();
        }
        public string ?ID;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHO.Text) || string.IsNullOrEmpty(tbMSSV.Text) || string.IsNullOrEmpty(tbTEN.Text) || string.IsNullOrEmpty(tbSDT.Text) || (rbNam.Checked==false&&rbNu.Checked==false) )
            {
                DialogResult rs = MessageBox.Show("KHONG DUOC DE? TRONG THONG TIN","CAUTION!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            LOP kq = Program.objdslop.Find(ID);
            SinhVien sv = new SinhVien();
            sv.Masv = tbMSSV.Text;
            sv.Ho = tbHO.Text;
            sv.Ten = tbTEN.Text;
            sv.Phai = true ? rbNam.Checked : false;
            sv.Sdt = tbSDT.Text;
            kq.dssv.Add(sv);
        }
    }
}
