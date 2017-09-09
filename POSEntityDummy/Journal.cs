//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntityDummy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public Journal()
        {
            this.Journal_Details = new HashSet<Journal_Details>();
            this.Payments = new HashSet<Payment>();
            this.Product_Supplier = new HashSet<Product_Supplier>();
            this.Sales = new HashSet<Sale>();
            this.Supports = new HashSet<Support>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Sub_Account_ID { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> PreparedBy { get; set; }
        public Nullable<int> AuthenticatedBy { get; set; }
    
        public virtual Login Login { get; set; }
        public virtual Login Login1 { get; set; }
        public virtual Sub_Accounts Sub_Accounts { get; set; }
        public virtual ICollection<Journal_Details> Journal_Details { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Product_Supplier> Product_Supplier { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Support> Supports { get; set; }
    }
}
