//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInformationSystem.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacultyDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacultyDetail()
        {
            this.Faculty = new HashSet<Faculty>();
        }
    
        public int ID { get; set; }
        public Nullable<int> HeadIndividualID { get; set; }
        public Nullable<int> VicePresidentIndividualID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faculty> Faculty { get; set; }
    }
}