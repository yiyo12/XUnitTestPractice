using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice_UnitTestWhitXUnit
{
    public class MailValidator
    {
     public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new MailNotProvidedException();
            

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }   

        public string IsSpam(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new MailNotProvidedException();
            

            List<string> spammDomains = new List<string>() { "spam.com", "doggy.com", "donttrust.com" };

            return spammDomains.Any(d => email.Contains(d)) ? "SPAM" : "INBOX";
        }
    }
}
