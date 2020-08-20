using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1 : EventBase
{
    private void Start()
    {
        //EventManager.Instance.AddEventListener(this, EM_EventType.Login, Login);
        EventManager.Instance.AddEventListener(this, EM_EventType.Game, Game);
        EventManager.Instance.AddEventListener(this, EM_EventType.Exit, Exit);
    }

    public void Login(EventParm parm)
    {
        Debug.Log("Login1" + "--" + parm.id + "--" + parm.name);
    }

    public void Game(EventParm parm)
    {
        Debug.Log("Game1" + "--" + parm.id + "--" + parm.name);
    }

    public void Exit(EventParm parm)
    {
        Debug.Log("Exit1" + "--" + parm.id + "--" + parm.name);
    }
}
