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
    
    public partial class Division
    {
        public Division()
        {
            this.Sites = new HashSet<Site>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        public int ControlAddress { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}
