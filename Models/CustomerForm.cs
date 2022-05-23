using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace xnes_hw.Models
{
    public class CustomerForm
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "שדה זה מוגבל ל 20 תווים")]
        [RegularExpression(@"^[a-z,A-Z]+$", ErrorMessage = " רק בעיברית")]
        [DisplayName("Hebrew Name:")]
        public string HebrewName { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "שדה זה מוגבל ל 15 תווים")]
        [RegularExpression(@"^[a-z,A-Z]+$", ErrorMessage = "נא לרשום באנגלית")]
        [DisplayName("English Name:")]
        public string EnglishName { get; set; }
        [Required]
        [DisplayName("Date of Birth:")]
        public DateTime BirthDate { get; set; }
        public int CustomerId { get; set; }
        // Foreign key to city
        //[ForeignKey("City")]
        public int CityId { get; set; }
        [Required]
        [DisplayName("City:")]
        public virtual City City { get; set; }
        [Required]
        [DisplayName("Bank:")]
        public string Bank { get; set; }
        // public int BankCode { get; set; }
        public string BankBranch { get; set; }
        //  public int BankBranchCode { get; set; }
        [Required]
        //[MaxLength(9, ErrorMessage = "שדה זה מוגבל ל 9 ספרות")]
        [DisplayName("Bank Account:")]
        public int BankAccount { get; set; }
    }
}