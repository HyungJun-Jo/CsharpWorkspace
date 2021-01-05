using DesignPatterns.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Class
{
    public class Observable
    {
        bool changed = false;
        List<IObserver> observers;

        public Observable()
        {
            observers = new List<IObserver>();          // 옵저버 객체들을 저장하기 위해 List 추가
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }

        public void NotifyObservers()
        {
            // 상태에 대해서 모든 옵저버들한테 알려주는 부분
            // 모두 IObserver 인터페이스를 구현하는 Update() 메소드가 있는 객체들이므로 손쉽게 알려줄 수 있습니다.
            if (changed)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(this);
                }
            }
            changed = false;
        }

        public void SetChanged()
        {
            changed = true;
        }
    }
}
