//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA45_Team10a_LibraryManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Librarian
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Librarian()
        {
            this.BookAdjustments = new HashSet<BookAdjustment>();
        }
    
        public int LibrarianID { get; set; }
        public string Title { get; set; }
        public string NRIC { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Salutation { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Postcode { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAdjustment> BookAdjustments { get; set; }
    }
}
