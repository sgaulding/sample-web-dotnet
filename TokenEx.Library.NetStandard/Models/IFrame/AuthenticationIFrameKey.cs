using System;
using System.Collections.Generic;
using System.Text;

namespace TokenEx.Library.NetStandard.Models.IFrame
{
    public class AuthenticationIFrameKey
    {
        public string TokenExID { get; set; }

        public string Origin { get; set; }

        public DateTime TimeStamp { get; set; }

        public TokenSchemeType TokenScheme { get; set; }
    }
}
