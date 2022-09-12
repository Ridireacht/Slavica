using System.Net;


namespace Slavica
{
    internal class Scrapper
    {

        // starts a translation process
        public static List<string> GetContents(string keyword)
        {   
            // data needed for code working
            const string api = "https://iapi.glosbe.com/iapi3/";
            List<string> languages = new() { "ru", "be", "uk", "rue", "orv", "pl", "csb", "szl",
                                             "hsb", "dsb", "pox", "cs", "sk", "czk", "sl", "hr",
                                             "sr", "sh", "bs", "mk", "bg", "cu", "cnr" };

            return GetResponses(MakeURLs(keyword, api, languages));
        }


        // creates a list of urls need to be parsed
        static List<string> MakeURLs(string keyword, string api, List<string> languages)
        {
            List<string> urls = new();
        

            // url creation and saving
            foreach(string lang in languages)
                urls.Add(api + "wordlist?l1=en&l2=" + lang + "&q=" + keyword + "&after=1&includeTranslations=true");

            return urls;
        }


        // gets responses from requests
        static List<string> GetResponses(List<string> urls)
        {
            List<string> responses = new();


            // getting response from each url
            foreach (string url in urls)
            {
                // Create a request for the URL.   
                WebRequest request = WebRequest.Create(url);

                // Get the response.  
                WebResponse response = request.GetResponse();

                // Get the stream containing content returned by the server.  
                Stream dataStream = response.GetResponseStream();

                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new(dataStream);

                // Read and save the content
                responses.Add(reader.ReadToEnd());

                // Clean up the streams and the response.  
                reader.Close();
                response.Close();
            }

            return responses;
        }

    }
}
