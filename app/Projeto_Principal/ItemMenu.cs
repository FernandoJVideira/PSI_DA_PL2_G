//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Principal
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemMenu()
        {
            this.Restaurante = new HashSet<Restaurante>();
        }
    
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public byte[] Fotografia { get; set; }
        public string Ingredientes { get; set; }
        public decimal Preco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurante> Restaurante { get; set; }
    }
}
