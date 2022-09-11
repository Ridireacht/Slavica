using System.Text.RegularExpressions;


namespace Slavica
{
    internal class Parser
    {

        // returns translated words
        public static List<string> ParseInfo(List<string> contents)
        {
            List<string> words = new();
            const string replacement = "";
            string temp;


            // Regex patterns preset
            Regex rgx1 = new Regex(",|{|}|[|]|:|: True");
            Regex rgx2 = new Regex(" '', '");
            Regex rgx3 = new Regex(" True', '");
            Regex rgx4 = new Regex("^'|'$', '");


            foreach (string content in contents)
            {
                // clearing the content
                temp = rgx1.Replace(content, replacement);
                temp = rgx2.Replace(temp, replacement);
                temp = rgx3.Replace(temp, replacement);
                temp = rgx4.Replace(temp, replacement);

                temp = Regex.Replace(temp, "after", "");
                temp = Regex.Replace(temp, "phrase", "");
                temp = Regex.Replace(temp, "translations", "");
                temp = Regex.Replace(temp, "success", "");

                words.Add(temp);
            }

            return words;
        }

    }
}
