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
    
    public partial class UserSite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
    
        public virtual Site Site { get; set; }
        public virtual Usertbl Usertbl { get; set; }
    }
}
