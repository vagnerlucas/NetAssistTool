using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetAssistToolClient.Observer
{
    public interface IObserver
    {
        void Update(Subject subject);
    }
}
