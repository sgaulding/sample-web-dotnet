using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace TokenExWebDemo.Models
{
    public class BBEViewModel
    {
        private string _firstName = string.Empty;
        private string _lastname = string.Empty;
        public string _cipherText = string.Empty;
        private int _expMonth = 0;
        private int _expYear = 0;
        private int _cvv = 0;

        public IEnumerable<SelectListItem> Years
        {
            get
            {
                return new SelectList(Utility.GenerateYears(), "key", "value");
            }
        }
        public IEnumerable<SelectListItem> Months
        {
            get
            {
                return new SelectList(Utility.GenerateMonths(), "key", "value");
            }
        }

        [Required]
        [DisplayName("First Name")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [Required]
        [DisplayName("Last Name")]
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        [Required]
        //[DisplayName("Exp Month (MM)")]
        public int ExpMonth
        {
            get { return _expMonth; }
            set { _expMonth = value; }
        }

        [Required]
        //[DisplayName("Exp Year (YY)")]
        public int ExpYear
        {
            get { return _expYear; }
            set { _expYear = value; }
        }

        [Required]
        [DisplayName("CVV")]
        [Range(100, 9999, ErrorMessage = "CVV is Invalid")]
        public int CVV
        {
            get { return _cvv; }
            set { _cvv = value; }
        }

        public string CipherText
        {
            get { return _cipherText; }
            set { _cipherText = value; }
        }


    }
}