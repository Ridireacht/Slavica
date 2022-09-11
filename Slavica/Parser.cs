using System.Text.RegularExpressions;


namespace Slavica
{
    internal class Parser
    {

        // returns translated words
        public static List<string> ParseInfo(List<string> contents)
        {
            List<string> words = new();
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

                temp = Regex.Replace(temp, "\"+", "\"");

                var tete = Regex.Split(temp, "\"");
                temp = tete[2] + " / " + tete[3];

                words.Add(temp);
            }

            return words;
        }

    }
}
