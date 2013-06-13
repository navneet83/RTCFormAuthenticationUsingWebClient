using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace RTCFormAuthenticationUsingWebClientDemo
{
  public class WebClientExtension : WebClient
      {
          //cookie container
          private CookieContainer _ckContainer = new CookieContainer();
  
          //request server 
          protected override WebRequest GetWebRequest(Uri _url)
          {
              WebRequest _request = base.GetWebRequest(_url);
              if (_request is HttpWebRequest)
              {
                  (_request as HttpWebRequest).CookieContainer = _ckContainer;
              }
              return _request;
          }
      }
  }
