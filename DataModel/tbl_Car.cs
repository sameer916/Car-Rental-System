//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public double DefaultPrice { get; set; }
        public int OwnerId { get; set; }
        public int AdminId { get; set; }
        public int RentalId { get; set; }
        public bool IsAvailable { get; set; }
    
        public virtual tbl_Admin tbl_Admin { get; set; }
        public virtual tbl_Owner tbl_Owner { get; set; }
        public virtual tbl_Rental tbl_Rental { get; set; }
    }
}
