//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameWork_1.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Action_Tree_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Action_Tree_Data()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Tickets1 = new HashSet<Ticket>();
            this.Tickets2 = new HashSet<Ticket>();
        }
    
        public int Action_Tree_DataId { get; set; }
        public int Level1_CategoryId { get; set; }
        public Nullable<int> Level2_CategoryId { get; set; }
        public Nullable<int> Level3_CategoryId { get; set; }
        public Nullable<int> Level4_CategoryId { get; set; }
        public Nullable<int> Parent_Action_Tree_DataId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Category Category1 { get; set; }
        public virtual Category Category2 { get; set; }
        public virtual Category Category3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets2 { get; set; }
    }
}