using System.Collections.Generic;
using PureMVC.Patterns.Observer;

public class ObserverManager
{
    private readonly Dictionary<object, List<Observer>> _observerMap = new Dictionary<object, List<Observer>>();

    public void RegisterObserver(object notificationName, Observer observer)
    {
        if (_observerMap.TryGetValue(notificationName, out var value))
        {
            value.Add(observer);
        }
        else
        {
            _observerMap[notificationName] = new List<Observer> { observer };
        }
    }

    public void RemoveObserver(object notificationName, object notifyContext)
    {
        if (_observerMap.ContainsKey(notificationName))
        {
            var observers = _observerMap[notificationName];
            observers.RemoveAll(observer => observer.CompareNotifyContext(notifyContext));
            
            if (observers.Count == 0)
            {
                _observerMap.Remove(notificationName);
            }
        }
    }

    public void NotifyObservers(Notification notification)
    {
        object notificationName = notification.Name;

        if (_observerMap.TryGetValue(notificationName, out var value))
        {
            var observers = new List<Observer>(value);

            foreach (var observer in observers)
            {
                observer.NotifyObserver(notification);
            }
        }
    }
}