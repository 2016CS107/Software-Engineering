//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Contact_Manage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int ContactId { get; set; }

        [Display(Name = "Contact Number")]
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Type { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
