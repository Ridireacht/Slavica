using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slavica
{
    internal class Scrapper
    {

        // starts a translation process
        public static List<string> GetContent(string keyword)
        {   
            // vars and data lists
            string api = "https://iapi.glosbe.com/iapi3/";
            List<string> languages = new List<string>() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                                      "hsb", "dsb", "pox", "cs", "sk", "sl", "hr",
                                                      "sr", "sh", "bs", "mk", "bg", "cu" };

            return GetResponses(MakeURLs(keyword, api, languages));
        }


        // creates a list of urls needed to be parsed
        static List<string> MakeURLs(string keyword, string api, List<string> languages)
        {
            List<string> urls = new List<string>();
            keyword = WordToURL(keyword);
        

            foreach(string lang in languages)
            {
                urls.Add(api + "wordlist?l1=en&l2=" + lang + "&q=" + keyword + "&after=1&includeTranslations=true");
            }

            return urls;
        }


        // gets responses from requests
        static List<string> GetResponses(List<string> urls)
        {
            List<string> responses = new List<string>();

            foreach (string url in urls)
            {
                // some
                // future
                //code
                responses.Add(response);
            }

            return responses;
        }


        // changes word form to the URL one
        static string WordToURL(string word)
        {
            return word;
        }
    }
}
