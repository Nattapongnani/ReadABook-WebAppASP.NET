//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReadaBookS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Book_id { get; set; }
        public string Book_Name { get; set; }
        public string Book_Url { get; set; }
        public Nullable<int> Book_CategoryID { get; set; }
        public string Book_Category { get; set; }
        public string Book_Author { get; set; }
    }
}
