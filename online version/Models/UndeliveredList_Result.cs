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
    
    public partial class UndeliveredList_Result
    {
        public int Product_id { get; set; }
        public string Comodity { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string SupplierName { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeleveringBy { get; set; }
        public string Status { get; set; }
        public Nullable<int> BuyingPrice { get; set; }
        public Nullable<int> SellingPrice { get; set; }
    }
}