using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slavica
{
    internal class Scrapper
    {
        // vars and data lists
        string api = "https://iapi.glosbe.com/iapi3/";
        List<string> urls = new List<string>();
        List<string> languages = new List<string>() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                                      "hsb", "dsb", "pox", "cs", "sk", "sl", "hr",
                                                      "sr", "sh", "bs", "mk", "bg", "cu" };
        public List<string> responses = new List<string>();


        // starts a translation process
        public void GetInfo(string keyword)
        {
            makeURLs(keyword);
            getResponses(urls);
        }


        // creates a list of urls needed to be parsed
        void makeURLs(string keyword)
        {
            keyword = wordToURL(keyword);

            foreach(string lang in languages)
            {
                urls.Add(api + "wordlist?l1=en&l2=" + lang + "&q=" + keyword + "&after=1&includeTranslations=true");
            }
        }


        // gets responses from requests
        void getResponses(List<string> urls)
        {
            string response = "";

            foreach (string url in urls)
            {
                // some
                // future
                //code
                responses.Add(response);
            }
        }


        // changes word form to the URL one
        string wordToURL(string word)
        {
            return word;
        }
    }
}
