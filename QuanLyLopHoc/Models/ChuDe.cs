//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLopHoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuDe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuDe()
        {
            this.BaiTaps = new HashSet<BaiTap>();
            this.TaiLieux = new HashSet<TaiLieu>();
        }
    
        public int MaChuDe { get; set; }
        public string TenChuDe { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> NguoiTao { get; set; }
        public Nullable<int> MaLopHoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiTap> BaiTaps { get; set; }
        public virtual LopHoc LopHoc { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieu> TaiLieux { get; set; }
    }
}