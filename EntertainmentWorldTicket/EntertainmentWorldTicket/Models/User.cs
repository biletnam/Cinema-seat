//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntertainmentWorldTicket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Us_ID { get; set; }
        public string Us_Name { get; set; }
        public string Us_FirstName { get; set; }
        public string Us_Email { get; set; }
        public string Us_Password { get; set; }
        public string Us_Address { get; set; }
        public int Us_PhoneNumber { get; set; }
        public int UType_ID { get; set; }
        public int B_ID { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual UserType UserType { get; set; }
    }
}