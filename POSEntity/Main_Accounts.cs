//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Main_Accounts
    {
        public Main_Accounts()
        {
            this.Sub_Accounts = new HashSet<Sub_Accounts>();
        }
    
        public int ID { get; set; }
        public string Catagory { get; set; }
    
        public virtual ICollection<Sub_Accounts> Sub_Accounts { get; set; }
    }
}
