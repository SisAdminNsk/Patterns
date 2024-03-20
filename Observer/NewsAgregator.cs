using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class NewsAgregator : IObservable<News>
    {
        private List<IObserver<News>> observers = new List<IObserver<News>>();

        public IDisposable Subscribe(IObserver<News> observer)
        {
            observers.Add(observer);
            UnSubscriber<News> cancellationToken = new UnSubscriber<News>(observers, observer);
            return cancellationToken;
        }

        public void Notify(News news)
        {
            foreach(var oberser  in observers)
            {
                oberser.OnNext(news);
            }
        }

    }
}
