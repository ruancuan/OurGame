using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool check = false;
    public int choice = 0;
    public List<EventBase> eventList = new List<EventBase>();
    EventParm parm = new EventParm();
    // Start is called before the first frame update
    void Start()
    {
        //Class1 class1 = new Class1();
        //Class2 class2 = new Class2();
        //Class3 class3 = new Class3();
        //eventList.Add(class1);
        //eventList.Add(class2);
        //eventList.Add(class3);


        InitParm();
    }

    private void InitParm()
    {
        parm.id = 1;
        parm.name = "123";
    }

    // Update is called once per frame
    void Update()
    {
        if (check&&parm!=null)
        {
            switch (choice)
            {
                case 1:
                    EventManager.Instance.RaiseEvent(EM_EventType.Login,parm);
                    break;
                case 2:
                    EventManager.Instance.RaiseEvent(EM_EventType.Game, parm);
                    break;
                case 3:
                    EventManager.Instance.RaiseEvent(EM_EventType.Exit, parm);
                    break;
                case 4:
                    EventManager.Instance.RemoveEventListener(eventList[0], EM_EventType.Game);
                    break;
                case 5:
                    EventManager.Instance.RemoveEventListener(eventList[1], EM_EventType.Login);
                    break;
                case 6:
                    EventManager.Instance.RemoveEventListener(eventList[2], EM_EventType.Exit);
                    break;
                default:

                    break;
            }
            check = false;
        }
    }
}
