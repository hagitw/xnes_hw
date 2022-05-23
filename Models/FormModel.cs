using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xnes_hw.Models
{
    public class FormModel
    {

        public Customer Customer { get; set; }

        [Required]
        [Display(Name = "City")]
        public string CityCode { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }

        [Required]
        [Display(Name = "Bank")]
        public string BankCode { get; set; }
        public IEnumerable<SelectListItem> Banks { get; set; }

        [Required]
        [Display(Name = "Bank Branch")]
        public string BankBranchCode { get; set; }
        public IEnumerable<SelectListItem> BankBranches { get; set; }
       

    }
}