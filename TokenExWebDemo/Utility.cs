using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenExWebDemo
{
    public static class Utility
    {
        public static Dictionary<string, string> GenerateMonths()
        {
            var months = new Dictionary<string, string>();
            Enumerable.Range(1, 12).ToList().ForEach(x => months.Add(x.ToString().PadLeft(2, '0'), x.ToString().PadLeft(2, '0')));
            return months;
        }

        public static Dictionary<string, string> GenerateYears()
        {
            var years = new Dictionary<string, string>();
            Enumerable.Range(DateTime.Now.Year, 10).ToList().ForEach(x => years.Add(x.ToString(), x.ToString()));
            return years;
        }
    }
}