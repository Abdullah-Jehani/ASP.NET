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
    
    public partial class superadmin
    {
        public string admin_name { get; set; }
        public string admin_password { get; set; }
        public string admin_status { get; set; }
        public int admin_number { get; set; }
    
        public virtual delete_employee delete_employee { get; set; }
        public virtual manage_employee_salary manage_employee_salary { get; set; }
        public virtual manage_employee_status manage_employee_status { get; set; }
        public virtual manage_manager_status manage_manager_status { get; set; }
    }
}