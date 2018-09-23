namespace TokenEx.Library.NetStandard.Models
{
    /// <summary>
    ///     https://docs.tokenex.com/?page=appendix#token-schemes
    /// </summary>
    public enum TokenSchemeType
    {
        sixTOKENfour = 1,

        fourTokenfour = 2,

        TOKENfour = 3,

        GUID = 4,

        SSN = 5,

        nGUID = 6,

        nTOKENfour = 7,

        nTOKEN = 8,

        sixANTOKENfour = 9,

        fourANTOKENfour = 10,

        ANTOKENfour = 11,

        ANTOKEN = 12,

        ANTOKENAUTO = 13,

        sixASCIITOKENfour = 16,

        fourASCIITOKENfour = 17,

        ASCIITOKENfour = 14,

        ASCIITOKEN = 15,

        ASCIITOKENAUTO = 18,

        sixNTOKENfour = 19,

        fourNTOKENfour = 20,

        NTOKENAUTO = 21,

        TOKEN = 22,

        sixTOKENfourNonLuhn = 23,

        fourTOKENfourNonLuhn = 24,

        TOKENfourNonLuhn = 25
    }
}