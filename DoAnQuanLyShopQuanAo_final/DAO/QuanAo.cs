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
    
    public partial class QuanAo
    {
        public QuanAo()
        {
            this.CT_HoaDon = new HashSet<CT_HoaDon>();
        }
    
        public string TenSP { get; set; }
        public string MaSP { get; set; }
        public string Loai { get; set; }
        public string Size { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public string Anh { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<int> GiamGia { get; set; }
    
        public virtual ICollection<CT_HoaDon> CT_HoaDon { get; set; }
    }
}
