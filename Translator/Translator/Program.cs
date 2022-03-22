using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Translator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TranslateText("Ahoj jak se máš?", "en");
        }
        
        public static string TranslateText(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate?hl=en&sl=en&tl={1}&text={0}", input, languagePair);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            string result = webClient.DownloadString(url);
            result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
            result = result.Substring(result.IndexOf(">") + 1);
            result = result.Substring(0, result.IndexOf("</span>"));
            return result.Trim();
        }
    }
}