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

    public partial class fMHedit : Form
    {
        public string tenmh;
        public fMHedit()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MonHoc rs = new MonHoc();
            if (tbTenMH.Text.Length == 0 || tbMaMH.Text.Length == 0 || tbSTCLT.Text.Length == 0 || tbSTCTH.Text.Length == 0)
            {
                DialogResult error = MessageBox.Show("CHUA NHAP DU? THONG TIN !!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rs.Tenmh = tbTenMH.Text;
            rs.Mamh = tbMaMH.Text;
            try
            {
                rs.Stclt = int.Parse(tbSTCLT.Text);
                rs.Stcth = int.Parse(tbSTCTH.Text);
            }
            catch
            {
                DialogResult error = MessageBox.Show("SAI DINH DANG!!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<MonHoc> temp = Program.objdsmh.ToList(Program.objdsmh.root);
            foreach (MonHoc m in temp) 
            {
                if (m.Tenmh == tbTenMH.Text)
                {
                    DialogResult error = MessageBox.Show("TRUNG TEN MON HOC!!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(m.Mamh == tbMaMH.Text)
                {
                    DialogResult error = MessageBox.Show("TRUNG MA~ MON HOC!!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Program.objdsmh.Add(rs);
            Program.objdsmh.Delete(tenmh);
            //Close();

        }

        private void fMHedit_Load(object sender, EventArgs e)
        {
            MonHoc mh = Program.objdsmh.Find(tenmh);
            tbMaMH.Text = mh.Mamh;
            tbTenMH.Text = mh.Tenmh;
            tbSTCLT.Text = mh.Stclt.ToString();
            tbSTCTH.Text = mh.Stcth.ToString();
        }
    }
}
