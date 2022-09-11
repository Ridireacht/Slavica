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


            foreach (string content in contents)
            {
                // clearing the content
                temp = Regex.Replace(content, @"\,|\{|\}|\[|\]|\:|\: True', '", "");
                temp = Regex.Replace(temp, @"\' \'', '\'", "");
                temp = Regex.Replace(temp, @" True', '", "");
                temp = Regex.Replace(temp, @"^\'|\'$', '", "");

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
