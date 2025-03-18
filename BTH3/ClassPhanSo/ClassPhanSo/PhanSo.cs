using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPhanSo
{
    internal class PhanSo
    {
        int tuso, mauso;
        //Constructor
        public PhanSo()
        {
            this.tuso = 0;
            this.mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso == 0 ? 1 : mauso;
        }
        //Property
        public int Tuso
        {
            get { return tuso;}
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso;}
            set { mauso = value; }
        }
        //Method
        private void Toigian()
        {
            int uc = ClassDungChung.UCLN(tuso, mauso);
            if( uc >0 )
            {
                tuso = tuso / uc;
                mauso = mauso / uc;
            }
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso*p.mauso+this.mauso*p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.mauso - this.mauso * p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.mauso;
            kq.mauso = this.mauso * p.tuso;
            kq.Toigian();
            return kq;
        }

    }
}
