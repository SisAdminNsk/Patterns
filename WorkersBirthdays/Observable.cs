using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public abstract class Observable
    {
        protected List<IObserver> observers = new List<IObserver>();
        public void Subscribe(IObserver subscriber)
        {
            observers.Add(subscriber);
        }

        public void UnSubscribe(IObserver subscriber)
        {
            observers.Remove(subscriber);
        }

        public virtual void Notify(object? parameter)
        {
            foreach(var observer in observers)
            {
                observer.Update(parameter);
            }
        }

        public Observable(List<IObserver> observers)
        {
            this.observers = observers;
        }
    }
}
