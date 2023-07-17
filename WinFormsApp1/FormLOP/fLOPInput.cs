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
    public partial class fLOPInput : Form
    {
        public fLOPInput()
        {
            InitializeComponent();
        }



        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) && string.IsNullOrEmpty(tbID.Text) && string.IsNullOrEmpty(tbYear.Text))
            {
                MessageBox.Show("Khong dc de? trong", "TB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                LOP obj = new LOP();
                obj.Malop = tbID.Text;
                obj.Tenlop = tbName.Text;
                obj.Year = int.Parse(tbYear.Text);
                Program.objdslop.Add(obj);
                Program.objdslop.display();
            }


        }
    }
}
