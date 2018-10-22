namespace Telephony
{
    public class Smartphone : IBrowsable, IPhonable
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