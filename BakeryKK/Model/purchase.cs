//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BakeryKK.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchase()
        {
            this.PurchaseProduct = new HashSet<PurchaseProduct>();
        }
    
        public int ID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime DateBuy { get; set; }
        public int EmployeeID { get; set; }
        public string ProductID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseProduct> PurchaseProduct { get; set; }
    }
}