using System.Text.RegularExpressions;

namespace UserApp
{
    internal class InputController
    {
        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            // regular expression that checks whether the entered name contains only letters and allowed characters
            string pattern = @"^[A-Za-z]*$";

            // Validate input using a regular expression
            return Regex.IsMatch(name, pattern);
        }
    }
}
