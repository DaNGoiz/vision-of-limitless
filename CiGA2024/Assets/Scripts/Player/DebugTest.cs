using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Messenger.Broadcast(MsgType.playerHurt);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            Messenger.Broadcast(MsgType.playerWin);
        }
        
    }
}
