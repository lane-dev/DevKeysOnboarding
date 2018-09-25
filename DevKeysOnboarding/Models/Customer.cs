//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevKeysOnboarding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.ProductSolds = new HashSet<ProductSold>();
        }
    
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer name is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special charecters are not allowed")]
        public string Name { get; set; }
        [Display(Name = "Customer Address")]
        [Required(ErrorMessage = "Please intput Customer Address")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSold> ProductSolds { get; set; }
    }
}
