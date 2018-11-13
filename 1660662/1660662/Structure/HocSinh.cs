using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1660662.Structure
{
    public class HocSinh
    {
        private int _MaHocSinh;
        private string _TenHocSinh;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private int _MaLop;

        public int MaHocSinh { get => _MaHocSinh; set => _MaHocSinh = value; }
        public string TenHocSinh {
            get => _TenHocSinh;
            set
            {
                var errorCounter = Regex.Matches(value, @"[0-9]").Count;
                if (errorCounter == 0)
                    _TenHocSinh = value;
                else
                    _TenHocSinh = null;
            }
        }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }
            set
            {
                if (value.ToLower() == "nam" || value.ToLower() == "nữ")
                    _GioiTinh = value;
                else
                    _GioiTinh = null;
            }
        }
        public int MaLop { get => _MaLop; set => _MaLop = value; }
    }
}
