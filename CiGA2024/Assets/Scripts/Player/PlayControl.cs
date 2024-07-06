using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class PlayControl : MonoBehaviour
{
    [Header("�������")]
    public Transform player;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;
    public Vector3 position;
    public bool isWalk;
    [Header("ײǽ���")]
    public bool touchWall;
    public Vector3 backPosition;
    public float backSmoothTime;
    [Header("���۱���")]
    public PlayerState isOpenEye = PlayerState.Open;
    private void FixedUpdate()
    {
        TouchWallEffect();
    }
    private void Update()
    {
        Move();
        ControlCheck();
        
    }

    public void Move()
    {
        transform.position = Vector3.SmoothDamp(transform.position,position, ref velocity, smoothTime);
        if(Vector2.SqrMagnitude(player.position-position)<0.001f)
        {
            player.position = position;
            isWalk = false;
        }

    }

    public void ControlCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isWalk == false)
        {
            ChangeEyeState();
        }
        if (Input.GetKeyDown(KeyCode.W)&&isWalk == false)
        {
            position.y += 1;
            position.z += -0.01f;
            isWalk = true;
            backPosition = new Vector3(position.x, position.y - 1, position.z );
            

        }
        if (Input.GetKeyDown(KeyCode.S) && isWalk == false)
        {
            position.y += -1;
            position.z += 0.01f;
            isWalk = true;
            backPosition = new Vector3(position.x, position.y + 1, position.z);
        }

        if (Input.GetKeyDown(KeyCode.A) && isWalk == false)
        {
            position.x += -1;
            isWalk = true;
            backPosition = new Vector3(position.x + 1, position.y, position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && isWalk == false)
        {
            position.x += 1;
            isWalk = true;
            backPosition = new Vector3(position.x - 1, position.y, position.z);
        }

    }

    public void TouchWallEffect()
    {
        //if(position.x > 0.5||position.y > 2.5)    //�����õ�
        //{                                         //�����õ�        
        //    touchWall = true;                     //�����õ�            
        //}                                         //�����õ�    
        if (touchWall == true)
        {
            transform.position = Vector3.SmoothDamp(transform.position, backPosition, ref velocity, backSmoothTime);
            position = backPosition;
            touchWall = false;
        }
    }
    private void ChangeEyeState()
    {
        isOpenEye = isOpenEye == PlayerState.Open ? PlayerState.Close : PlayerState.Open;
        Messenger.Broadcast<PlayerState>(MsgType.changeOpenCloseEye, isOpenEye);
    }

}