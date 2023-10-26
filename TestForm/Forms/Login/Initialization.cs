using System.Collections.Generic;
using System.IO;

namespace LoginPassword
{
    class Initialization
    {
        internal static Dictionary<string, string> AssignUsernames()
        {
            var usernames = new Dictionary<string, string>();
            var lines = File.ReadAllLines(@"\\pgea-store-01\Students\pgeaA0\Documents\ТП\LoginPassword\LoginPassword\bin\Debug\logins.txt");

            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = lines[i];
                var data = line.Split(',');
                usernames.Add(data[0], data[1]);
            }

            return usernames;
        }
    }
}
