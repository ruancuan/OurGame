using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class3 : EventBase
{
    void Start()
    {
        EventManager.Instance.AddEventListener(this, EM_EventType.Login, Login);
        EventManager.Instance.AddEventListener(this, EM_EventType.Game, Game);
        //EventManager.Instance.AddEventListener(this, EM_EventType.Exit, Exit);
    }
    public void Login(EventParm parm)
    {
        Debug.Log("Login3" + "--" + parm.id + "--" + parm.name);
    }

    public void Game(EventParm parm)
    {
        Debug.Log("Game3" + "--" + parm.id + "--" + parm.name);
    }

    public void Exit(EventParm parm)
    {
        Debug.Log("Exit3" + "--" + parm.id + "--" + parm.name);
    }
}
