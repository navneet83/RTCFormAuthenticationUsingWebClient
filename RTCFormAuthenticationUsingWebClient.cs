using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace RTCFormAuthenticationUsingWebClientDemo
{
  class RTCFormAuthenticationUsingWebClient
    {
        static void Main()
        {
            //create object of WebClientExtension class
            using (var _webClient = new WebClientExtension())
            {
                var _serverResponse1 = _webClient.DownloadString("https://localhost:9443/jazz/authenticated/identity");
                //set username and password
                var data = new NameValueCollection
                {
                  { "j_username", "UserName" },
                  { "j_password", "Password" },
                };
                //authenticate
                var _serverResponse2 = _webClient.UploadValues("https://localhost:9443/jazz/authenticated/j_security_check", data);
                Console.WriteLine(Encoding.Default.GetString(_serverResponse2));
            }
        }
      }
}
