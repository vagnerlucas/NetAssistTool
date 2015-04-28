using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetAssistToolClient.Observer
{
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObjects()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

    }
}
