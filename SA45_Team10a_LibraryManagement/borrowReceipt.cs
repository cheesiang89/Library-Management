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
    
    public partial class BorrowReceipt
    {
        public int TransactionID { get; set; }
        public string BookID { get; set; }
        public string BookTitle { get; set; }
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateBorrow { get; set; }
        public System.DateTime DateDue { get; set; }
    }
}
