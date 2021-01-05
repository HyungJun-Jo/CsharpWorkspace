using DesignPatterns.Observer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Interface
{
    public interface IObserver
    {
        void Update(Observable obs);            // 옵저버한테 측정된 값 전달
    }
}
