using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Reader : IObserver<News>
    {
        public string Name { get; set; }

        public void OnNext(News news)
        {
            Console.WriteLine(Name);
            Console.WriteLine(news.Title);
            Console.WriteLine(news.Description);
            Console.WriteLine();
        }

        public void OnError(Exception err)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public Reader(string name)
        {
            Name = name;
        }
    }
}
