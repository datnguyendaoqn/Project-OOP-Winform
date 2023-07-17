using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Class;


namespace WinFormsApp1.DanhSach
{
    internal class DSLop
    {
        private LinkedList<LOP> listlop = new LinkedList<LOP>();
        public DSLop()
        {
        }
        public void Add(LOP lop) 
        {
            if (listlop.Count == 0) 
            {
            listlop.AddFirst(lop);
            }
            else
            {
                LinkedListNode<LOP>root = listlop.First;
                while(root != null) 
                {
                    if (root.Value.Malop==lop.Malop)
                    {
                        DialogResult rs = MessageBox.Show("KO DUOC TRUNG` MA LOP", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    root = root.Next;
                }
                listlop.AddFirst(lop);
                
            }

        }
        public void delete(string ID)
        {
            LinkedListNode<LOP> root = listlop.First;
            while (root.Value.Malop != ID)
            {
                root = root.Next;
              
            }
            listlop.Remove(root);
            display();
        }
       public void display()
        {
            Program.form1.lvDSLOP.Items.Clear();
            LinkedListNode<LOP> root = listlop.First;
            while (root !=null)
            {
                ListViewItem data = new ListViewItem(root.Value.Malop);
                data.SubItems.Add(root.Value.Tenlop);
                data.SubItems.Add(root.Value.Year.ToString());
                Program.form1.lvDSLOP.Items.Add(data);
                root = root.Next;
            }
        }
        public void display(int year)
        {
            List<LOP> rs = listlop.Where(x => x.Year == year).ToList();
            Program.form1.lvDSLOP.Items.Clear();

            foreach (LOP item in rs) 
            {
                ListViewItem data = new ListViewItem(item.Malop);
                data.SubItems.Add(item.Tenlop);
                data.SubItems.Add(item.Year.ToString());
                Program.form1.lvDSLOP.Items.Add(data);
            }
        }
        public LOP Find(string ID)
        {
            LinkedListNode<LOP> rs = listlop.First;
            while (rs.Value.Malop != ID) 
            {
                rs=rs.Next;
            }
            LOP kq = rs.Value;
            return kq;
            
        }

    }
}
