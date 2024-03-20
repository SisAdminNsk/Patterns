using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class News
    {
        public string Title {  get; set; }
        public string Description { get; set; }

        public News(string title,string desc)
        {
           Title = title;
            Description = desc;
        }
    }
}
