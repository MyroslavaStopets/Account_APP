using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Account_App
{
    class Helpers
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;
        public static string Hash(string password, int iterations = 10000)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hash_bytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hash_bytes, 0, SaltSize);
            Array.Copy(hash, 0, hash_bytes, SaltSize, HashSize);
            var base64_hash = Convert.ToBase64String(hash_bytes);
            return string.Format("$MYHASH$V1${0}${1}", iterations, base64_hash);
        }
        public static bool Is_hash_supported(string hash_string)
        {
            return hash_string.Contains("$MYHASH$V1$");
        }
        public static bool Verify(string password, string hashed_password)
        {
            if (!Is_hash_supported(hashed_password))
            {
                throw new NotSupportedException("The hashtype is not supported");
            }
            var splitted_hash_string = hashed_password.Replace("$MYHASH$V1$", "").Split('$');
            var iterations = int.Parse(splitted_hash_string[0]);
            var base64_hash = splitted_hash_string[1];
            var hash_bytes = Convert.FromBase64String(base64_hash);
            var salt = new byte[SaltSize];
            Array.Copy(hash_bytes, 0, salt, 0, SaltSize);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);
            for (var i = 0; i < HashSize; i++)
            {
                if (hash_bytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Valid_surname_name(string s)
        {
            Regex regex = new Regex(@"^[a-z]+$");
            s = s.ToLower();
            if (regex.IsMatch(s))
            {
                return true;
            }
            return false;
        }
        public static bool Valid_role(string s)
        {
            if (s == "client" || s == "bank")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Valid_double_number(double s)
        {
            string t = Convert.ToString(s);
            Regex regex = new Regex(@"^\d+\.*\d*$");
            if (regex.IsMatch(t))
            {
                return true;
            }
            return false;
        }
        public static bool Valid_number(int y)
        {
            string s = Convert.ToString(y);
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(s))
            {
                return true;
            }
   
            return false;
        }

        public static bool Valid_email(string s)
        {
            Regex regex = new Regex(@"^.+@.+\..+$");
            //^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$ 袗袘袨
            //^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$
            s = s.ToLower();
            if (regex.IsMatch(s))
            {
                return true;
            }
            return false;
        }
        public static bool Valid_password(string s)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})");
            if (regex.IsMatch(s))
            {
                return true;
            }
            return false;
        }
    }
}
