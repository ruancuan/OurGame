using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 事件基类,需要进行事件监听和触发的类需要基础该类
/// </summary>
public class EventBase : MonoBehaviour
{
    private int key=0;
    public int Key
    {
        get
        {
            if (key == 0)
                Awake();
            return key;
        }
    }
    private Dictionary<string, Action<EventParm>> dict = new Dictionary<string, Action<EventParm>>();

    private void Awake()
    {
        key = GetInstanceID();
    }

    public void AddEventListener(EM_EventType type,Action<EventParm> action)
    {
        string key = Enum.GetName(type.GetType(), type);
        if (dict.ContainsKey(key))
        {
            dict[key] += action;
        }
        else
        {
            dict.Add(key, action);
        }
    }

    public void RaiseEvent(EM_EventType type,EventParm parm)
    {
        string key = Enum.GetName(type.GetType(), type);
        if (dict.ContainsKey(key))
        {
            dict[key](parm);
        }
    }

    public void RemoveEventListener(EM_EventType type)
    {
        string key = Enum.GetName(type.GetType(), type);
        if (dict.ContainsKey(key))
        {
            dict.Remove(key);
        }
    }

    public void RemoveAllEventListener()
    {
        if (dict != null)
        {
            dict.Clear();
        }
    }

    public void OnDestroy()
    {
        EventManager.Instance.RemoveAllEventListener(this);
        RemoveAllEventListener();
    }
}
