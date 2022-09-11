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



            foreach (string content in contents)
            {
                // clearing the content
                temp = rgx1.Replace(content, replacement);

                words.Add(temp);
            }

            return words;
        }

    }
}
