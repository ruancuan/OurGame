using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventParm 
{
    public int id;
    public string name="";
}

public enum EM_EventType
{
    None,
    Login,
    Game,
    Exit,
}