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
        List<string> responses = new List<string>();
        List<string> languages = new List<string>() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                                      "hsb", "dsb", "pox", "cs", "sk", "sl", "hr",
                                                      "sr", "sh", "bs", "mk", "bg", "cu" };


        // starts a translation process
        void Get(string keyword)
        {
            makeURLs(keyword);
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


        // changes word form to the URL one
        string wordToURL(string word)
        {
            return word;
        }
    }
}
