//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace online_version.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class UndeliveredList_Result
    {
        public int Product_id { get; set; }
        public string Comodity { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string SupplierName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeleveringBy { get; set; }
        public string Status { get; set; }
    }
}
