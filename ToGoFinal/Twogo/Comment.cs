//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToGo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public int OrderID { get; set; }
        public int OrderCode { get; set; }
        public int TripTypeNum { get; set; }
        public string Comment1 { get; set; }
        public decimal CPStars { get; set; }
        public decimal LocationPoint { get; set; }
        public decimal CleanPoint { get; set; }
        public decimal ServicePoint { get; set; }
        public decimal FacilityPoint { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual TripType TripType { get; set; }
    }
}
