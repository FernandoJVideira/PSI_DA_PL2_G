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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.ItemMenu = new HashSet<ItemMenu>();
        }
    
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public int EstadoId { get; set; }
        public int RestauranteId { get; set; }
    
        public virtual Trabalhador Trabalhador { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemMenu> ItemMenu { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
