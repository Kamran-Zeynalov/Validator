using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountValidator
{

    public class EmailValidator
    {
        public static bool Validate(string email)
        {
            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("Email is invalid");
            }
            if (email.Length - 9 < 10) // burada -9 "@mail.com"-un Lengthidir.
            {
                throw new ShortEmailException("Email is short");
            }

            return true;
        }
    }
}
