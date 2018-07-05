using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using static System.Int32;

namespace ByJGService
{
    public abstract class Base
    {
        private const string Url = "http://www.byjg.com.br/ws/";
        private readonly string _service;

        protected Base(string service)
        {
            _service = service;
        }

        protected List<string> Get(string method, Dictionary<string, string> args)
        {
            var requestUrl = Url + _service + "/?httpmethod=" + method;
            
            // Loop over pairs with foreach.
            foreach (var pair in args)
            {
                requestUrl += "&" + pair.Key + "=" + pair.Value;
            }
            
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            string body;
            using(var response = (HttpWebResponse)request.GetResponse())
            using(var stream = response.GetResponseStream())
            using(var reader = new StreamReader(stream))
            {
                body = reader.ReadToEnd();
            }

            var resultArgs = body.Split('|');

            if (resultArgs[0] != "OK")
            {
                throw new Exception(body);
            }
            
            if (resultArgs[1] == "ARRAY")
            {
                return ParseArray(resultArgs, 3, Parse(resultArgs[2]));
            }

            if (TryParse(resultArgs[1], out var count))
            {
                return ParseArray(resultArgs, 2, count);
            }

            var result = new List<string>
            {
                resultArgs[1]
            };

            return result;
        }

        private static List<string> ParseArray(IReadOnlyList<string> resultArgs, int start, int count)
        {
            var result = new List<string>();

            for (var i = 0; i < count; i++)
            {
                result.Add(resultArgs[start + i]);
            }

            return result;
        }
    }
}