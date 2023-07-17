using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Class;

namespace WinFormsApp1.DanhSach
{
    
    internal class DSSV
    {
        class sortSV : IComparer<SinhVien>
        {
            public int Compare(SinhVien a, SinhVien b)
            {
                if (a.Ten.CompareTo(b.Ten) > 0)
                    return 1;
                else if (a.Ten.CompareTo(b.Ten) < 0)
                    return -1;
                else
                    return 0;
                
            }
        }
        private List<SinhVien> listsv;
        public DSSV() 
        {
           listsv  = new List<SinhVien>();
        }
        public void Add(SinhVien sv)
        {
            foreach (SinhVien item in listsv)
            {
                if (item.Masv == sv.Masv)
                {
                    DialogResult rs = MessageBox.Show("KO DUOC TRUNG MASV !!!", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            listsv.Add(sv);
            Display();
        }
        public void Delete(string ID) 
        {
            for ( int i = 0; i < listsv.Count; i++ ) 
            {
                if (listsv[i].Masv == ID)
                {
                    listsv.RemoveAt(i);
                    Display();
                }
            }
        }
        public void Edit(string ID)
        {
            for (int i = 0; i < listsv.Count; i++)
            {
                if (listsv[i].Masv == ID)
                {
                    SinhVien rs = listsv[i];
                }
            }
        }
        public void Display()
        {
            listsv.Sort(new sortSV());
            Program.form1.lvDSSV.Items.Clear();
            foreach(SinhVien item in listsv)
            {
                ListViewItem lvitem = new ListViewItem(item.Masv);
                lvitem.SubItems.Add(item.Ho);
                lvitem.SubItems.Add(item.Ten);
                lvitem.SubItems.Add(item.Phai == true ? "Nam" : "Nu");
                lvitem.SubItems.Add(item.Sdt);
                Program.form1.lvDSSV.Items.Add(lvitem);
            }
        }
        public SinhVien Find(string MSSV)
        {
            SinhVien kq = listsv.Where(x=>x.Masv == MSSV).SingleOrDefault();
            return kq;
        }
    }
}
