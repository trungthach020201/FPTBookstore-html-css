//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPTBOOKSTORE_TEMPLETE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Orderdetails = new HashSet<Orderdetail>();
        }
    
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Img { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string CategoryId { get; set; }
        public string AuthorId { get; set; }
        public System.DateTime DateAdd { get; set; }
        public string Description { get; set; }
        public Nullable<int> Authors_AuthorId { get; set; }
        public Nullable<int> Categoies_CategoryId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
