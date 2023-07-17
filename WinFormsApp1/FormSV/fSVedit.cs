using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Class;
using WinFormsApp1.DanhSach;

namespace WinFormsApp1
{
    public partial class fSVedit : Form
    {
        public string idlop;
        public string mssv;
        LOP lop;
        SinhVien sv;
        public fSVedit()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            sv.Ho = tbHO.Text;
            sv.Ten=tbTEN.Text;
            sv.Sdt=tbSDT.Text;
            sv.Phai = true ? rbNAM.Checked==true : false;
            lop.dssv.Display();
        }

        private void fSVedit_Load(object sender, EventArgs e)
        {
            lop = Program.objdslop.Find(idlop);
            sv = lop.dssv.Find(mssv);
            tbHO.Text = sv.Ho;
            tbTEN.Text = sv.Ten;
            tbSDT.Text = sv.Sdt;
            rbNU.Checked = true ? sv.Phai == false : false;
            rbNAM.Checked=true?sv.Phai == true : false;
        }
    }
}
