using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Class;

namespace WinFormsApp1.DanhSach
{
    internal class DSMH
    {
        public MonHoc root;
        private void Addwithroot( ref MonHoc node,MonHoc mh)
        {
            if (node == null)
            {
                node = mh;
            }
            else
            {
                if (node.Mamh == mh.Mamh)
                {
                    DialogResult rs = MessageBox.Show("KO DUOC TRUNG MA MH!!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (node.Tenmh.CompareTo(mh.Tenmh) > 0)
                {
                    Addwithroot(ref node.left, mh);
                }
                else if (node.Tenmh.CompareTo(mh.Tenmh) < 0)
                {
                    Addwithroot(ref node.right, mh);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("KO DUOC TRUNG TEN MH!!!", "CAUTION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public void Add(MonHoc mh)
        {
            Addwithroot(ref this.root, mh);               
        }
        public List<MonHoc> ToList(MonHoc root)
        {
            void Addtolist(MonHoc mh,List<MonHoc> listmh)
            {
                if (mh!=null)
                {

                    Addtolist(mh.left,listmh);
                    listmh.Add(mh);
                    Addtolist(mh.right, listmh);
                }
            }
            List<MonHoc> list = new List<MonHoc>();
            Addtolist(root,list);
            return list;
         
        }
        public void display()
        {
            List<MonHoc> list = ToList(this.root);
            Program.form1.lvDSMH.Items.Clear();
            foreach(MonHoc mh in list)
            {
                ListViewItem item = new ListViewItem(mh.Mamh);
                item.SubItems.Add(mh.Tenmh);
                item.SubItems.Add(mh.Stclt.ToString());
                item.SubItems.Add(mh.Stcth.ToString());
                Program.form1.lvDSMH.Items.Add(item);
            }
        }
        private MonHoc Nodephainhat(MonHoc node)
        {
            if (node.left==null)
            {
                return node;
            }
            return Nodephainhat(node.left);
        }
        private void Deletewithroot(ref MonHoc node, string obj)
        {
            if (node.Tenmh == obj)
            {
                    if (node.left == null && node.right == null)
                        { node = null; }

                    else if (node.left != null || node.right != null)
                    {
                        if (node.left == null) 
                            { node = node.right; }
                        else if (node.right == null)
                            { node = node.left; }
                        else
                        {
                            MonHoc temp = Nodephainhat(node.right);
                            MonHoc.copyvalue(temp, ref node);
                            if (temp.right != null)
                                temp = temp.right;
                            else
                                Deletewithroot(ref node, temp.Tenmh);
                        }
                    }
            }
            else if (node.Tenmh.CompareTo(obj) > 0)
            {
                Deletewithroot(ref node.left, obj);
            }
            else
            {
                Deletewithroot(ref node.right, obj);
            }
        }
        private MonHoc findwithroot(MonHoc node,string tenmh)
        {
            if(node.Tenmh == tenmh)
            {
                return node;
            }
            else
            {
                if(node.Tenmh.CompareTo(tenmh)>0)
                {
                    return findwithroot(node.left, tenmh);
                }
                else
                {
                    return findwithroot(node.right, tenmh);
                }
            }
            return null;
        }
        public MonHoc Find(string tenmh)
        {
            return findwithroot(this.root, tenmh);
        }
        public void Delete(string tenmh)
        {
            Deletewithroot(ref this.root, tenmh);
        }
    }
}
