//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using HealthcareManagementSystem.Utilities;
using System.Security.Cryptography;

namespace HealthcareManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuperUser : User
    {
        public string SuperHashedPassword { get; set; }
        public string SuperPassword
        {
            set { SuperHashedPassword = PasswordUtilities.ComputeHash(value, new MD5CryptoServiceProvider()); }
        }
    }
}