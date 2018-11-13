using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1660662.Structure
{
    public class LopHoc
    {
        private int _MaLop;
        private int _SiSo;
        private int _LopTruong;
        private int _GVQuanLy;
        private DateTime _NamBatDau;
        private DateTime _NamKetThuc;

        public int MaLop { get => _MaLop; set => _MaLop = value; }
        public int SiSo { get => _SiSo; set => _SiSo = value; }
        public int LopTruong { get => _LopTruong; set => _LopTruong = value; }
        public int GVQuanLy { get => _GVQuanLy; set => _GVQuanLy = value; }
        public DateTime NamBatDau { get => _NamBatDau; set => _NamBatDau = value; }
        public DateTime NamKetThuc { get => _NamKetThuc; set => _NamKetThuc = value; }
    }
}
