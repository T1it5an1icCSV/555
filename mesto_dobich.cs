//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace posled_practos
{
    using System;
    using System.Collections.Generic;
    
    public partial class mesto_dobich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mesto_dobich()
        {
            this.drag_camni = new HashSet<drag_camni>();
        }
    
        public int id_dobich { get; set; }
        public string mesto_dobich1 { get; set; }
        public Nullable<int> country_id { get; set; }
        public Nullable<int> post_dost_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drag_camni> drag_camni { get; set; }
        public virtual strana strana { get; set; }
        public virtual postavchik postavchik { get; set; }
    }
}
