//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonedasConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moneda()
        {
            this.MonedasPrecios = new HashSet<MonedasPrecio>();
        }
    
        public int MonedaId { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonedasPrecio> MonedasPrecios { get; set; }
    }
}