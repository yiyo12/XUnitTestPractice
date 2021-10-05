using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_UnitTestWhitXUnit
{
   public class MailNotProvidedException: Exception
    {
        public override string Message => "Email cant be empty";
    }
}
