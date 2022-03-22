﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ShopQuanAoEntities : DbContext
    {
        public ShopQuanAoEntities()
            : base("name=ShopQuanAoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<QuanAo> QuanAos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual int CAPNHATHD(string mahd, Nullable<System.DateTime> ngaylap, Nullable<int> idNVien, Nullable<decimal> thanhTien)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var idNVienParameter = idNVien.HasValue ?
                new ObjectParameter("idNVien", idNVien) :
                new ObjectParameter("idNVien", typeof(int));
    
            var thanhTienParameter = thanhTien.HasValue ?
                new ObjectParameter("thanhTien", thanhTien) :
                new ObjectParameter("thanhTien", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATHD", mahdParameter, ngaylapParameter, idNVienParameter, thanhTienParameter);
        }
    
        public virtual int CAPNHATNV(Nullable<int> id, string ten, Nullable<System.DateTime> ngsinh, string phai, Nullable<decimal> luong, string sdt, Nullable<int> ngaynghi)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var ngsinhParameter = ngsinh.HasValue ?
                new ObjectParameter("ngsinh", ngsinh) :
                new ObjectParameter("ngsinh", typeof(System.DateTime));
    
            var phaiParameter = phai != null ?
                new ObjectParameter("phai", phai) :
                new ObjectParameter("phai", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(decimal));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var ngaynghiParameter = ngaynghi.HasValue ?
                new ObjectParameter("ngaynghi", ngaynghi) :
                new ObjectParameter("ngaynghi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATNV", idParameter, tenParameter, ngsinhParameter, phaiParameter, luongParameter, sdtParameter, ngaynghiParameter);
        }
    
        public virtual int CAPNHATTK(string mk, string tentk)
        {
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPNHATTK", mkParameter, tentkParameter);
        }
    
        public virtual ObjectResult<SPKHONGBANDUOC_Result> SPKHONGBANDUOC(Nullable<int> thang)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPKHONGBANDUOC_Result>("SPKHONGBANDUOC", thangParameter);
        }
    
        public virtual int SUASANPHAM(string tensp, string masp, string loai, string size, Nullable<int> soluong, Nullable<decimal> dongia, Nullable<int> giamgia)
        {
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var loaiParameter = loai != null ?
                new ObjectParameter("loai", loai) :
                new ObjectParameter("loai", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var giamgiaParameter = giamgia.HasValue ?
                new ObjectParameter("giamgia", giamgia) :
                new ObjectParameter("giamgia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUASANPHAM", tenspParameter, maspParameter, loaiParameter, sizeParameter, soluongParameter, dongiaParameter, giamgiaParameter);
        }
    
        public virtual int THEMCT_HOADON(string mahd, string masp, Nullable<int> soluong, Nullable<decimal> dongia)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMCT_HOADON", mahdParameter, maspParameter, soluongParameter, dongiaParameter);
        }
    
        public virtual int THEMHOADON(string mahd, Nullable<System.DateTime> ngaylap, Nullable<int> id, Nullable<decimal> thanhtien)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var thanhtienParameter = thanhtien.HasValue ?
                new ObjectParameter("thanhtien", thanhtien) :
                new ObjectParameter("thanhtien", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMHOADON", mahdParameter, ngaylapParameter, idParameter, thanhtienParameter);
        }
    
        public virtual int THEMNV(string ten, Nullable<System.DateTime> ngsinh, string phai, Nullable<decimal> luong, string sdt)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var ngsinhParameter = ngsinh.HasValue ?
                new ObjectParameter("ngsinh", ngsinh) :
                new ObjectParameter("ngsinh", typeof(System.DateTime));
    
            var phaiParameter = phai != null ?
                new ObjectParameter("phai", phai) :
                new ObjectParameter("phai", typeof(string));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(decimal));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMNV", tenParameter, ngsinhParameter, phaiParameter, luongParameter, sdtParameter);
        }
    
        public virtual int THEMSANPHAM(string tensp, string masp, string loai, string size, Nullable<int> soluong, Nullable<decimal> dongia, string anh, Nullable<int> giamgia)
        {
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var loaiParameter = loai != null ?
                new ObjectParameter("loai", loai) :
                new ObjectParameter("loai", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var anhParameter = anh != null ?
                new ObjectParameter("anh", anh) :
                new ObjectParameter("anh", typeof(string));
    
            var giamgiaParameter = giamgia.HasValue ?
                new ObjectParameter("giamgia", giamgia) :
                new ObjectParameter("giamgia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMSANPHAM", tenspParameter, maspParameter, loaiParameter, sizeParameter, soluongParameter, dongiaParameter, anhParameter, giamgiaParameter);
        }
    
        public virtual int THEMTK(string tentk, string mk, string loai, Nullable<int> id)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var loaiParameter = loai != null ?
                new ObjectParameter("loai", loai) :
                new ObjectParameter("loai", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMTK", tentkParameter, mkParameter, loaiParameter, idParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> TONGTIENTHEONGAY(Nullable<System.DateTime> ngay1, Nullable<System.DateTime> ngay2)
        {
            var ngay1Parameter = ngay1.HasValue ?
                new ObjectParameter("ngay1", ngay1) :
                new ObjectParameter("ngay1", typeof(System.DateTime));
    
            var ngay2Parameter = ngay2.HasValue ?
                new ObjectParameter("ngay2", ngay2) :
                new ObjectParameter("ngay2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("TONGTIENTHEONGAY", ngay1Parameter, ngay2Parameter);
        }
    
        public virtual int XOAHD(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOAHD", mahdParameter);
        }
    
        public virtual int XOANV(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOANV", idParameter);
        }
    
        public virtual int XOASANPHAM(string masp)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOASANPHAM", maspParameter);
        }
    
        public virtual int XOATK(string tentk)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOATK", tentkParameter);
        }
    }
}
