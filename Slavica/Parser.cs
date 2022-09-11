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
                string v = Regex.Replace(content, ",|{|}|[|]|:|: True", ' ');
                words.Add(v);
            }

            return contents;
        }

    }
}
