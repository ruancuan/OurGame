using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2 : EventBase
{

    private void Start()
    {
        EventManager.Instance.AddEventListener(this, EM_EventType.Login, Login);
        //EventManager.Instance.AddEventListener(this, EM_EventType.Login, Login);
        EventManager.Instance.AddEventListener(this, EM_EventType.Exit, Exit);
    }
    public void Login(EventParm parm)
    {
        Debug.Log("Login2" + "--" + parm.id + "--" + parm.name);
    }

    public void Game(EventParm parm)
    {
        Debug.Log("Game2" + "--" + parm.id + "--" + parm.name);
    }

    public void Exit(EventParm parm)
    {
        Debug.Log("Exit2" + "--" + parm.id + "--" + parm.name);
    }
}
