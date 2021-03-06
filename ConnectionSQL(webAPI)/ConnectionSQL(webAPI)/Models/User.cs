//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectionSQL_webAPI_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserLoginDetails = new HashSet<UserLoginDetail>();
            this.UserSecAnsDetails = new HashSet<UserSecAnsDetail>();
        }
    
        public int UserId { get; set; }
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "This field is required.")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name:")]
        [Required(ErrorMessage = "This field is required.")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name:")]
        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }
        [DisplayName("Email:")]
        [Required(ErrorMessage = "This field is required.")]
        public string EmailAddress { get; set; }
        [DisplayName("Password:")]
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Contact:")]
        [Required(ErrorMessage = "This field is required.")]
        public string PhoneNumber { get; set; }
        [DisplayName("Unique Id Number:")]
        [Required(ErrorMessage = "This field is required.")]
        public string UserUniqueId { get; set; }
        [DisplayName("Country:")]
        [Required(ErrorMessage = "This field is required.")]
        public int CountryId { get; set; }
        [DisplayName("State:")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<int> StateId { get; set; }
        [DisplayName("City:")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<int> CityId { get; set; }
        [DisplayName("Address Line 1:")]
        [Required(ErrorMessage = "This field is required.")]
        public string AddressLine1 { get; set; }
        [DisplayName("Address Line 2:")]
        public string AddressLine2 { get; set; }
        [DisplayName("Postal Code:")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<decimal> Pincode { get; set; }
        [DisplayName("Security Question:")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<int> SecurityQuestionId { get; set; }
        [DisplayName("User Type:")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<int> UserTypeId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual UserType UserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLoginDetail> UserLoginDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSecAnsDetail> UserSecAnsDetails { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
