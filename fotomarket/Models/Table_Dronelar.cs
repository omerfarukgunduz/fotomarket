//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fotomarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Dronelar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Dronelar()
        {
            this.Table_CokSatanlar = new HashSet<Table_CokSatanlar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public string UrunFiyati { get; set; }
        public string UrunGorseli { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_CokSatanlar> Table_CokSatanlar { get; set; }
        public virtual Table_Markalar Table_Markalar { get; set; }
    }
}
