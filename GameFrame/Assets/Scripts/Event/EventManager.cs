using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 事件监听的管理类,用来进行时间的绑定和触发
/// </summary>
public class EventManager 
{
    private static EventManager _instance;
    public static EventManager Instance
    {
        get
        {
            if(_instance==null)
                _instance = new EventManager();
            return _instance;
        }
    }

    private Dictionary<int, EventBase> dict = new Dictionary<int, EventBase>();

    /// <summary>
    /// 获取字典的键值
    /// </summary>
    /// <returns></returns>
    public int GetDictKey(EventBase obj)
    {
        return obj.Key;
    }

    public void AddEventListener(EventBase obj,EM_EventType type,Action<EventParm> action)
    {
        int key = GetDictKey(obj);
        if (dict.ContainsKey(key))
        {
            dict[key].AddEventListener(type, action);
        }
        else
        {
            dict.Add(key, obj);
            obj.AddEventListener(type, action);
        }
    }

    public void RaiseEvent(EM_EventType type,EventParm parm)
    {
        var enumerator= dict.GetEnumerator();

        while (enumerator.MoveNext())
        {
            EventBase obj= enumerator.Current.Value;
            if (obj)
            {
                obj.RaiseEvent(type, parm);
            }
        }

        enumerator.Dispose();
    }

    public void RemoveEventListener(EventBase obj,EM_EventType type)
    {
        int key = GetDictKey(obj);
        if (dict.ContainsKey(key))
        {
            dict[key].RemoveEventListener(type);
        }
    }

    public void RemoveAllEventListener(EventBase obj)
    {
        int key = GetDictKey(obj);
        if (dict.ContainsKey(key))
        {
            dict[key].RemoveAllEventListener();
        }
    }

}
