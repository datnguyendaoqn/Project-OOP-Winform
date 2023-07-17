using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Class
{
    internal class MonHoc
    {
        private string mamh;
        private string tenmh;
        private int stclt;
        private int stcth;
        public MonHoc left;
        public MonHoc right;
        public static void copyvalue(MonHoc obj, ref MonHoc mh)
        {
            mh.mamh = obj.mamh;
            mh.tenmh = obj.tenmh;
            mh.stclt = obj.stclt;
            mh.stcth = obj.stcth;
        }
      
        //public MonHoc(MonHoc mh)
        //{
        //  mamh = mh.mamh;
        //    tenmh = mh.tenmh;
        //    stclt = mh.stclt;
        //    stcth = mh.stcth;
        //    left = mh.left;
        //    right = mh.right;
        //}

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int Stclt { get => stclt; set => stclt = value; }
        public int Stcth { get => stcth; set => stcth = value; }
    }
}
