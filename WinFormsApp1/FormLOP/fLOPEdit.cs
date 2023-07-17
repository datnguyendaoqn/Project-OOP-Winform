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

namespace WinFormsApp1
{
    public partial class fLOPEdit : Form
    {
        public fLOPEdit()
        {
            InitializeComponent();
        }
        public string ID;

        private void btnOK_Click(object sender, EventArgs e)
        {
            LOP kq = Program.objdslop.Find(ID);
            kq.Tenlop = tbName.Text;
            kq.Year = int.Parse(tbYear.Text);
            Program.objdslop.display();
        }
    }
}
