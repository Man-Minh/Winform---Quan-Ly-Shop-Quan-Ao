using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Phai { get; set; }
        public decimal Luong { get; set; }
        public string SDT { get; set; }
        public int SoNgayNghi { get; set; }

    }
}
