using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatePasswords
{
    public static class StringExtensions
    {
        // See if the password satisfies the indicated criteria.
        public static bool PasswordIsValid(this string password,
            int minLength, int maxLength,
            bool allowLowercase, bool requireLowercase,
            bool allowUppercase, bool requireUppercase,
            bool allowDigit, bool requireDigit,
            bool allowSpecial, bool requireSpecial,
            bool allowOther, bool requireOther, string other)
        {
            // See if the password has an allowed length.
            if ((password.Length < minLength) || (password.Length > maxLength))
                return false;

            const string lowers = "abcdefghijklmnopqrstuvwxyz";
            const string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specials = @"~!@#$%^&*():;[]{}<>,.?/\|";

            // Check requirements.
            if (requireLowercase &&
                (password.IndexOfAny(lowers.ToCharArray()) < 0))
                    return false;
            if (requireUppercase &&
                (password.IndexOfAny(uppers.ToCharArray()) < 0))
                    return false;
            if (requireDigit &&
                (password.IndexOfAny(digits.ToCharArray()) < 0))
                    return false;
            if (requireSpecial &&
                (password.IndexOfAny(specials.ToCharArray()) < 0))
                    return false;
            if (requireOther &&
                (password.IndexOfAny(other.ToCharArray()) < 0))
                    return false;

            // Make a string containing all allowed characters.
            string allowed = "";
            if (allowLowercase) allowed += lowers;
            if (allowUppercase) allowed += uppers;
            if (allowDigit) allowed += digits;
            if (allowSpecial) allowed += specials;
            if (allowOther) allowed += other;

            // Make sure all characters in the password are allowed.
            password = password.Trim(allowed.ToCharArray());
            if (password.Length > 0) return false;

            return true;
        }
    }
}
