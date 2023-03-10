//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public class PlayerInput 
//{
//    PlayerActions playerAction;

//    public event EventHandler OnWireConnectPressed;


//    private void Awake()
//    {
//        playerAction = new PlayerActions();
//        playerAction.player.Enable();  //enable action map

//    }

//    private void Update()
//    {
//        if(playerAction.player.wire.IsPressed())
//        {
//            OnWireConnectPressed?.Invoke(this, EventArgs.Empty);
//        }
//    }
//}
