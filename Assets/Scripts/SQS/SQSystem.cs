using System.Collections.Generic;

namespace SQS
{
    public class SQSystem
    {
        private readonly List<IQuestObserver> _observers = new();
        public bool IsInit { get; private set; }

        public void Init()
        {
            IsInit = true;
        }

        public void AddObserver(IQuestObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IQuestObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Update()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
        
        public void Destroy()
        {
            _observers.Clear();
            IsInit = false;
        }
    }
}