using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class UnSubscriber<T> : IDisposable
    {
        private List<IObserver<T>> observers;
        private IObserver<T> observer;

        public UnSubscriber(List<IObserver<T>> observers,IObserver<T> observer)
        {
            this.observer = observer;
            this.observers = observers;
        }

        public void Dispose()
        {
            if(observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}
