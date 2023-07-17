using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Class;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        #region LOP
        private void btnLoad_Click(object sender, EventArgs e)
        {
            fLOPInput input = new fLOPInput();
            input.Show();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string key = "";
            if (lvDSLOP.SelectedItems.Count > 0)
            {
                key = lvDSLOP.SelectedItems[0].Text;
            }
            else
            {
                DialogResult rs = MessageBox.Show("CHUA CHON O CAN` XOA'", "CAUTION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.objdslop.delete(key);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvDSLOP.SelectedItems.Count > 0)
            {
                fLOPEdit edit = new fLOPEdit();
                edit.ID = lvDSLOP.SelectedItems[0].Text;
                edit.tbName.Text = lvDSLOP.SelectedItems[0].SubItems[1].Text;
                edit.tbYear.Text = lvDSLOP.SelectedItems[0].SubItems[2].Text;
                edit.Show();

            }
            else
            {
                DialogResult rs = MessageBox.Show("CHUA CHON O CAN` SUA?'", "CAUTION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbYear.Text))
            {
                DialogResult rs = MessageBox.Show("CHUA NHAP NIEN KHOA !!!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.objdslop.display(int.Parse(tbYear.Text));

        }
        #endregion

        #region SINHVIEN
        private void btnAddsv_Click(object sender, EventArgs e)
        {
            if (lvDSLOP.SelectedItems.Count == 0)
            {
                DialogResult rs = MessageBox.Show("CHUA CHON LOP!!! ", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fSVinput fSVinput = new fSVinput();
            fSVinput.ID = lvDSLOP.SelectedItems[0].Text;
            fSVinput.Show();

        }

        private void btnXoasv_Click(object sender, EventArgs e)
        {
            LOP lop = Program.objdslop.Find(lvDSLOP.SelectedItems[0].Text);
            string ID = lvDSSV.SelectedItems[0].Text;
            lop.dssv.Delete(ID);
        }

        private void btnEditsv_Click(object sender, EventArgs e)
        {
            if (lvDSLOP.SelectedItems.Count == 0)
            {
                DialogResult rs = MessageBox.Show("CHUA CHON LOP!!! ", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lvDSSV.SelectedItems.Count == 0)
            {
                DialogResult rs = MessageBox.Show("CHUA CHON SINH VIEN CAN` SUA? ", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fSVedit edit = new fSVedit();
            edit.idlop = lvDSLOP.SelectedItems[0].Text;
            edit.mssv = lvDSSV.SelectedItems[0].Text;
            edit.Show();
        }

        #endregion
        #region MONHOC
        private void btnAddMH_Click(object sender, EventArgs e)
        {
            fMHinput input = new fMHinput();
            input.StartPosition = FormStartPosition.CenterScreen;
            input.Show();
        }

        private void btnDeleteMH_Click(object sender, EventArgs e)
        {
            if (lvDSMH.SelectedItems.Count == 0)
            {
                DialogResult rs = MessageBox.Show("CHUA CHON MON HOC!!! ", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenmh = Program.form1.lvDSMH.SelectedItems[0].SubItems[1].Text;
            Program.objdsmh.Delete(tenmh);
            Program.objdsmh.display();
        }

        private void btnEditMH_Click(object sender, EventArgs e)
        {
            if (lvDSMH.SelectedItems.Count == 0)
            {
                DialogResult rs = MessageBox.Show("CHUA CHON MON HOC CAN SUA? !!! ", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fMHedit edit = new fMHedit();
            edit.tenmh = lvDSMH.SelectedItems[0].SubItems[1].Text;
            edit.StartPosition = FormStartPosition.CenterScreen;
            edit.Show();
        }
    #endregion
    }
}
      /*using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false) // thuộc tính EndOfStream = true nghĩa là đã đọc hết dữ liệu rồi
                {
                    string line = sr.ReadLine(); // sr nó sẽ đọc từng dòng và lưu vào line
    string[] values = line.Split(','); // nó sẽ cắt line thành tưởng chuỗi nhỏ hơn dữa vào dấu ","

    // dựa vào chỉ số của mảng để truy xuất nội dung từng cột ở đây
    Lop lop1 = new Lop();
    lop1.maLop = values[0];
                    lop1.tenLop = values[1];
                    lop1.namHoc = Convert.ToInt32(values[2]);

                    DsSinhVien objectDsSinhVien = new DsSinhVien();
    lop1.dssv = objectDsSinhVien;
                    for (int i = 0; i<Program.objectDslop.length(); i++)
                    {
                        if (Program.objectDslop.dsLop[i].maLop == values[0])
                        {
                            MessageBox.Show(
                            "Mã lớp bị trùng!",
                            "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
} */