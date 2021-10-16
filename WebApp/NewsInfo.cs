using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class NewsInfo
    {
        public class articles
        {
            public source source { get; set; }
            public string author { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string publishedAt { get; set; }
            public string content { get; set; }
        }

        public class source
        {
            public string name { get; set; }
        }

    }
}
