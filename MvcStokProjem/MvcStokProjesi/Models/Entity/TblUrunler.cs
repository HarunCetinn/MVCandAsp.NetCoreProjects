//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStokProjesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUrunler()
        {
            this.TblSatıslar = new HashSet<TblSatıslar>();
        }
    
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public Nullable<short> UrunKategori { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<byte> Stok { get; set; }
    
        public virtual TblKategoriler TblKategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSatıslar> TblSatıslar { get; set; }
    }
}
