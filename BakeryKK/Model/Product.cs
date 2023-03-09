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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductHistory = new HashSet<ProductHistory>();
            this.PurchaseProduct = new HashSet<PurchaseProduct>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public int ManufactureID { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProdTypeID { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductHistory> ProductHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseProduct> PurchaseProduct { get; set; }
    }
}
