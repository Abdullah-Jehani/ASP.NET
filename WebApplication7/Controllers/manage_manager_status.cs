//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class manage_manager_status
    {
        public int admin_num { get; set; }
        public Nullable<int> manager_number { get; set; }
        public string manager_new_status { get; set; }
    
        public virtual superadmin superadmin { get; set; }
        public virtual manager manager { get; set; }
    }
}