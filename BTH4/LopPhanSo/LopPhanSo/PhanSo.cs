using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopPhanSo
{
    class PhanSo
    {
        int ts, ms;
        public PhanSo()
        {
            this.ts = 0;
            this.ms = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.ts = tuso;
            this.ms = mauso == 0 ? 1 : mauso;
        }
        public int Tuso
        {
            get { return this.ts; }
            set { this.ts = value; }
        }
        public int Mauso
        {
            get { return this.ms; }
            set { this.ms = value; }
        }
        //METHOD
        private void Toigian()
        {
            int uc = ClassDungChung.UCLN(ts, ms);
            if (uc > 0)
            {
                ts = ts / uc;
                ms = ms / uc;
            }
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = this.ts * p.ms + this.ms * p.ts;
            kq.ms = this.ms * p.ms;
            kq.Toigian();
            return kq;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = this.ts * p.ms - this.ms * p.ts;
            kq.ms = this.ms * p.ms;
            kq.Toigian();
            return kq;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = this.ts * p.ts;
            kq.ms = this.ms * p.ms;
            kq.Toigian();
            return kq;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = this.ts * p.ms;
            kq.ms = this.ms * p.ts;
            kq.Toigian();
            return kq;
        }
    }
}
