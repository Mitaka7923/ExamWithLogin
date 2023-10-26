using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LoginPassword
{
    public class DataValidator
    {
        private Dictionary<string, string> usernames;
        private string username;

        public DataValidator(Dictionary<string, string> usernames, string username)
        {
            this.usernames = usernames;
            this.username = username;
        }

        internal bool CheckPassword(string password)
        {
            var regex = new Regex(@"^(?=.*[0-9])(?=.*[A-Z]).{8,}$");
            var match = regex.Match(password);

            return match.Success;
        }

        internal bool ValidatePassword(string input)
        {
            if (usernames.TryGetValue(username, out string password) &&
                input.Trim() == (password))
            {
                return true;
            }

            return false;
        }

        internal bool ValidateUsername(string inputUsername)
        {
            username = inputUsername;

            if (usernames.ContainsKey(inputUsername.Trim()))
                return true;

            return false;
        }
    }
}
