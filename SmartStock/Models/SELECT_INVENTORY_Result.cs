//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartStock.Models
{
    using System;
    
    public partial class SELECT_INVENTORY_Result
    {
        public int intInventoryID { get; set; }
        public string strProductName { get; set; }
        public int intInvCount { get; set; }
        public string strUnitType { get; set; }
        public bool blnIsLow { get; set; }
        public int intCategoryID { get; set; }
        public int intProductLocationID { get; set; }
    }
}
