namespace Telephony
{
    using System;
    using System.Linq;
    public class Smartphone : IPhonable, IBrowsable
    {
        public string Browse(string website)
        {
            Validator.WebSite(website);

            return "Browsing: " + website + "!";
        }

        public string Call(string number)
        {
            Validator.Number(number);

            return "Calling... " + number;
        }
    }
}