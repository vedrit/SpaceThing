using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomEvents : MonoBehaviour
{
    static CustomEvents eventManager;

    public static CustomEvents instance { get { return eventManager; } }
    [Serializable] public class intEvent : UnityEvent<int> { }
    public class twoIntEvent : UnityEvent<int, int> { }
    public class stringEvent : UnityEvent<string> { }
    public class TwoStringEvent : UnityEvent<string, string> { }

    private Dictionary<string, UnityEvent> genericEventDictionary = new Dictionary<string, UnityEvent>();
    private Dictionary<string, intEvent> intEventDictionary = new Dictionary<string, intEvent>();
    private Dictionary<string, twoIntEvent> twoIntEventDictionary = new Dictionary<string, twoIntEvent>();
    private Dictionary<string, stringEvent> stringEventDictionary = new Dictionary<string, stringEvent>();
    private Dictionary<string, TwoStringEvent> twoStringEventDictionary = new Dictionary<string, TwoStringEvent>();
    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null)
		{
            Destroy(gameObject);
		}
        else
        {
            eventManager = this;
            DontDestroyOnLoad(gameObject);
        }
        genericEventDictionary = new Dictionary<string, UnityEvent>();
        intEventDictionary = new Dictionary<string, intEvent>();
        twoIntEventDictionary = new Dictionary<string, twoIntEvent>();
        stringEventDictionary = new Dictionary<string, stringEvent>();
        twoStringEventDictionary = new Dictionary<string, TwoStringEvent>();
    }
    #region Generic events
    public static void StartListening(string eventName, UnityAction listener)
    {
        UnityEvent tempEvent = null;
        if (instance.genericEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.AddListener(listener);
        }
        else
        {
            tempEvent = new UnityEvent();
            tempEvent.AddListener(listener);
            instance.genericEventDictionary.Add(eventName, tempEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction listener)
    {
        UnityEvent tempEvent = null;
        if (instance.genericEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName)
    {
        UnityEvent tempEvent = null;
        if (instance.genericEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.Invoke();
        }
    }
    #endregion
    #region Single int events
    public static void StartListening(string eventName, UnityAction<int> listener)
    {
        intEvent tempEvent = null;
        if (instance.intEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.AddListener(listener);
        }
        else
        {
            tempEvent = new intEvent();
            tempEvent.AddListener(listener);
            instance.intEventDictionary.Add(eventName, tempEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction<int> listener)
    {
        intEvent tempEvent = null;
        if (instance.intEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName, int value)
    {
        //Debug.Log("Attempting to trigger event " + eventName);
        intEvent tempEvent = null;
        if (instance.intEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.Invoke(value);
        }
    }
    #endregion
    #region Two int events
    public static void StartListening(string eventName, UnityAction<int, int> listener)
    {
        twoIntEvent tempEvent = null;
        if (instance.twoIntEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.AddListener(listener);
        }
        else
        {
            tempEvent = new twoIntEvent();
            tempEvent.AddListener(listener);
            instance.twoIntEventDictionary.Add(eventName, tempEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction<int, int> listener)
    {
        twoIntEvent tempEvent = null;
        if (instance.twoIntEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName, int value, int value2)
    {
        //Debug.Log("Attempting to trigger event " + eventName);
        twoIntEvent tempEvent = null;
        if (instance.twoIntEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.Invoke(value, value2);
        }
    }
    #endregion
    #region Single string events
    public static void StartListening(string eventName, UnityAction<string> listener)
    {
        stringEvent tempEvent = null;
        if (instance.stringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.AddListener(listener);
        }
        else
        {
            tempEvent = new stringEvent();
            tempEvent.AddListener(listener);
            instance.stringEventDictionary.Add(eventName, tempEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction<string> listener)
    {
        stringEvent tempEvent = null;
        if (instance.stringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName, string value)
    {
        stringEvent tempEvent = null;
        if (instance.stringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.Invoke(value);
        }
    }
    #endregion
    #region Two string events
    public static void StartListening(string eventName, UnityAction<string, string> listener)
    {
        TwoStringEvent tempEvent = null;
        if (instance.twoStringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.AddListener(listener);
        }
        else
        {
            tempEvent = new TwoStringEvent();
            tempEvent.AddListener(listener);
            instance.twoStringEventDictionary.Add(eventName, tempEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction<string, string> listener)
    {
        TwoStringEvent tempEvent = null;
        if (instance.twoStringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName, string value1, string value2)
    {
        TwoStringEvent tempEvent = null;
        if (instance.twoStringEventDictionary.TryGetValue(eventName, out tempEvent))
        {
            tempEvent.Invoke(value1, value2);
        }
    }
    #endregion
}
