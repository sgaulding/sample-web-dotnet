using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace TokenExWebDemo.Models
{
    public class IframeViewModel
    {
        private string _firstName = string.Empty;
        private string _lastname = string.Empty;
        public string _iframeData = string.Empty;
        private int _expMonth = 0;
        private int _expYear = 0;
        private int _cvv = 0;
        private string _token = string.Empty;
        private string _HMAC;

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
        public string HMAC
        {
            get { return _HMAC; }
            set { _HMAC = value; }
        }


        [Required]
        public string Token
        {
            get { return _token; }
            set { _token = value; }
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

        public string IframeData

        {
            get { return _iframeData; }
            set { _iframeData = value; }
        }


    }
}