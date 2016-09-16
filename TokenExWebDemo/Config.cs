using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TokenExWebDemo
{
    public class Config
    {
        public static string TokenExID
        {
            get
            {
                return ConfigurationManager.AppSettings["TokenEXID"];
            }
        }

        public static string APIKey
        {
            get
            {
                return ConfigurationManager.AppSettings["APIKey"];
            }
        }
        public static string BBEURL
        {
            get
            {
                return ConfigurationManager.AppSettings["BBETokenizeEndpoint"];
            }
        }
        public static string HTPCSS
        {
            get
            {
                return ConfigurationManager.AppSettings["HTP_CSS"];
            }
        }
        public static string HTPHMACKey
        {
            get
            {
                return ConfigurationManager.AppSettings["HTP_HMACKey"];
            }
        }
        public static string HTPURL
        {
            get
            {
                return ConfigurationManager.AppSettings["HTPEndpoint"];
            }
        }
        public static int  TokenScheme
        {
            get
            {
                int tokenscheme = 0;
                if (!int.TryParse(ConfigurationManager.AppSettings["TokenScheme"], out tokenscheme))
                {
                    tokenscheme = 1;
                }
                return tokenscheme;
            }
        }

    }
}