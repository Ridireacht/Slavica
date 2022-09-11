using System.Text.RegularExpressions;


namespace Slavica
{
    internal class Parser
    {

        // returns translated words
        public static List<string> ParseInfo(List<string> contents)
        {
            List<string> words = new();

            foreach (string content in contents)
            {
                string pattern = ",|{|}|[|]|:|: True";
                Regex rgx = new Regex(pattern);

                string replacement = "";

                string v = rgx.Replace(content, replacement);
                words.Add(v);
            }

            return words;
        }

    }
}
