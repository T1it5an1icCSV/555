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
    
    public partial class uveliri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uveliri()
        {
            this.rolee = new HashSet<rolee>();
        }
    
        public int id_uveliri { get; set; }
        public string name_uveliri { get; set; }
        public string surname_uvelriri { get; set; }
        public string otchestvo_uvelri { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rolee> rolee { get; set; }
    }
}
