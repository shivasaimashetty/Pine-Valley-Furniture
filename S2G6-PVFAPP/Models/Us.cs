//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S2G6_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Us
    {
        public string usesID { get; set; }
        public string GoesIntoQuantity { get; set; }
        public string productID { get; set; }
        public string materialID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Raw_Material Raw_Material { get; set; }
    }
}
