using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPhanSo
{
    internal class ClassDungChung
    {   //Dung static de co the truy cap ClassDungChung.UCLN cho nhanh
        public static int UCLN(int a, int b)
        {
            int a1=Math.Abs(a);
            int b1=Math.Abs(b);
            if(b==0)
                return a1;
            return UCLN(b1,a1%b1);
        }
    }
}
