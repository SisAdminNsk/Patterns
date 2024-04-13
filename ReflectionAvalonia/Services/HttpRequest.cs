using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAvalonia.Services
{
    public static class HttpRequest
    {
        public static string Request(string uriString)
        {
            var uri = new Uri(uriString);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonData = "";
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    jsonData = reader.ReadToEnd();
                }

                return jsonData;
            }
            else
            {
                throw new HttpRequestException();
            }
        }
    }
}
