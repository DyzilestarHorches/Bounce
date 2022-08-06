using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new MyEvent", menuName = "MyEvent", order = 55)]
public class SO_MyEvent : ScriptableObject
{
    [SerializeField] public List<MyEventListener> listeners = new List<MyEventListener>();
    [SerializeField] private string[] listenersName;

    public void Trigger()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventTriggered();
        }
    }


    //support in-code register and remove
    public void RegisterListener(MyEventListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(MyEventListener listener)
    {
        listeners.Remove(listener);
    }
}
