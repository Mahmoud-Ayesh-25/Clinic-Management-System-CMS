using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVLD_Project.MainSettings
{
    public class clsValidation
    {
        static public bool IsDigit(char c)
        {
            if (char.IsDigit(c)) return true;
            if ((Keys)c == Keys.Back) return true;

            return false;
        }

        static public bool IsValidDate(DateTime date)
        {
            if (date.Date > (DateTime.Now.Date))
                return false;

            if (date.Date < (DateTime.Now.AddYears(-150)))
                return false;

            return true;
        }

        static public bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
            
            return regex.IsMatch(email);
        }
    }
}
