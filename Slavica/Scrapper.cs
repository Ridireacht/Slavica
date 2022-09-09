using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slavica
{
    internal class Scrapper
    {
        string api = "https://iapi.glosbe.com/iapi3/";
        List<string> urls = new List<string>();
        List<string> languages = new List<string>() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                                      "hsb", "dsb", "pox", "cs", "sk", "sl", "hr",
                                                      "sr", "sh", "bs", "mk", "bg", "cu" };

        void Get(string keyword)
        {
            keyword = wordToURL(keyword);


        }


        // changes word form to the URL one
        string wordToURL(string word)
        {
            return null;
        }
    }
}
