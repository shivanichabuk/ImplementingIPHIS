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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Answer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Answer()
        {
            this.UserSecAnsDetails = new HashSet<UserSecAnsDetail>();
        }
    
        public int AnswerId { get; set; }
        [DisplayName("Security Question: ")]
        [Required(ErrorMessage = "This field is required.")]
        public Nullable<int> SecurityQuestionId { get; set; }
        [DisplayName("Answer: ")]
        [Required(ErrorMessage = "This field is required.")]
        public string Answer1 { get; set; }
        [DisplayName("Answer: ")]
        [Required(ErrorMessage = "This field is required.")]
        public string Answer2 { get; set; }
        [DisplayName("Answer: ")]
        [Required(ErrorMessage = "This field is required.")]
        public string Answer3 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        [NotMapped]
        public List<SecurityQuestion> QuestionCollection { get; set; }

        public virtual SecurityQuestion SecurityQuestion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSecAnsDetail> UserSecAnsDetails { get; set; }
    }
}
