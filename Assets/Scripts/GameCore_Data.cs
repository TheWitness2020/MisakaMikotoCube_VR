using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameCore_Data
{
    public static int locked = 0;
    public static GameObject pl;
    static GameCore_Data()
    {
        pl = GameObject.Find("Playercam");
    }
}
