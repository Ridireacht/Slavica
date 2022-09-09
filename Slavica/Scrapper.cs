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
            // data needed for code working
            const string api = "https://iapi.glosbe.com/iapi3/";
            List<string> languages = new() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                             "hsb", "dsb", "pox", "cs", "sk", "sl", "hr",
                                             "sr", "sh", "bs", "mk", "bg", "cu" };

            return GetResponses(MakeURLs(keyword, api, languages));
        }


        // creates a list of urls need to be parsed
        static List<string> MakeURLs(string keyword, string api, List<string> languages)
        {
            List<string> urls = new();
            keyword = WordToURL(keyword);
        

            // url creation and saving
            foreach(string lang in languages)
            {
                urls.Add(api + "wordlist?l1=en&l2=" + lang + "&q=" + keyword + "&after=1&includeTranslations=true");
            }

            return urls;
        }


        // gets responses from requests
        static List<string> GetResponses(List<string> urls)
        {
            List<string> responses = new();


            // getting response from each url
            foreach (string url in urls)
            {
                // there
                // will
                // be
                // some
                // code

                responses.Add(response);
            }

            return responses;
        }


        // changes word format to the URL-compatible one
        static string WordToURL(string word)
        {
            return word;
        }
    }
}
