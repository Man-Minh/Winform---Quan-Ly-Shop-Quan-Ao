//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int ID { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Phai { get; set; }
        public Nullable<decimal> Luong { get; set; }
        public string SDT { get; set; }
        public Nullable<int> SoNgayNghi { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}