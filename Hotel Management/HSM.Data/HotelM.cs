//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSM.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HotelM()
        {
            this.Rooms = new HashSet<Room>();
        }
    
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Contact_Number { get; set; }
        public string Contact_Person { get; set; }
        public string Website { get; set; }
        public string FaceBook { get; set; }
        public string Twitter { get; set; }
        public string IsActive { get; set; }
        public System.DateTime Create_date { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public string Updated_By { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
