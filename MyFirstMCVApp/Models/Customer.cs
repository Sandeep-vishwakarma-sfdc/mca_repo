using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMCVApp.Models {
    public class Customer {
        [Required(ErrorMessage = "Please Enter Id")]
        public int CustId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string CustName { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public String CustAdd { get; set; }
    }
}