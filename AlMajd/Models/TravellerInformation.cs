//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlMajd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravellerInformation
    {
        public int travellerId { get; set; }
        public Nullable<int> travellerIdentify { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public Nullable<int> numberOfTravellers { get; set; }
        public Nullable<int> numberDarebeh { get; set; }
        public Nullable<int> serviceId { get; set; }
        public Nullable<System.DateTime> dateOfTravel { get; set; }
    
        public virtual ServiceType ServiceType { get; set; }
    }
}
