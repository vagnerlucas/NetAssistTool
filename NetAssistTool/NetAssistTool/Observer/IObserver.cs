using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetAssistTool.Observer
{
    public interface IObserver
    {
        void Update(Subject subject);
    }
}
