using System.Collections;
using System.Collections.Generic;
using UnderCloud;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Messenger.Broadcast(MsgType.playerHurt);
        }

        if(Input.GetKeyDown(KeyCode.Equals))
        {
            Messenger.Broadcast(MsgType.reachExit);
        }

        // if(Input.GetKeyDown(KeyCode.G))
        // {
        //     Messenger.Broadcast(MsgType.reachExit);
        // }

        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            PlayerPrefs.SetInt("maxLevelIndex", 0);
        }

        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            PlayerPrefs.SetInt("maxLevelIndex", 32); // max level = 32
        }
    }
}
