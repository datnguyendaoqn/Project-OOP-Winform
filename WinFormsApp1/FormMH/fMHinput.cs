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
    public partial class fMHinput : Form
    {
        public fMHinput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaMH.Text)||string.IsNullOrEmpty(tbTenMH.Text) || string.IsNullOrEmpty(tbSTCLT.Text.ToString())||string.IsNullOrEmpty(tbSTCTH.Text.ToString())) 
            {
                DialogResult rs = MessageBox.Show("KHONG DC DE TRONG' CAC THONG TIN !!!","CAUTION!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            MonHoc mh = new MonHoc();
            mh.Mamh=tbMaMH.Text;
            mh.Tenmh=tbTenMH.Text;
            try
            {
                mh.Stclt = int.Parse(tbSTCLT.Text);
                mh.Stcth = int.Parse(tbSTCTH.Text);
            }
            catch
            {
                DialogResult rs = MessageBox.Show("THONG TIN KO DUNG TYPE !!!","CAUTION!!!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.objdsmh.Add(mh);
            Program.objdsmh.display();

        }
    }
}
