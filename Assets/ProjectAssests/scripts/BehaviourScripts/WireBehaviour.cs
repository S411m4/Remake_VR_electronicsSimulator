using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBehaviour : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    private Transform currentNode;
    private Transform connectedToNode;

    private void Awake()
    {
        line.positionCount = 2;
        currentNode = this.transform;
        line = this.GetComponent<LineRenderer>();
    }

    private void Start()
    {
        //if connectedTo is null , subscribe to the event of instantiating new one
    }


}





//public class wireBehavior 
//{

//    GameObject[] wires;



//    void Update()
//    {
//        if (connectedTo == null)
//        {
//            //line disappear when other terminal not connected
//            line.SetPosition(0, current.position);
//            line.SetPosition(1, current.position);

//            wires = GameObject.FindGameObjectsWithTag("wire");

//            foreach (GameObject item in wires)
//            {
//                //Debug.Log(item.name);

//                if (item.GetComponent<wireBehavior>().connectedTo == null && item.GetComponent<wireBehavior>().current != this.gameObject.transform) //to check that item don't connect to itself
//                {
//                    //Debug.Log("connectTo");
//                    this.connectedTo = item.gameObject.transform;
//                    item.GetComponent<wireBehavior>().connectedTo = this.transform;
//                    //Debug.Log("connected");
//                }
//            }
//            //Debug.Log("done");
//        }

//        if (connectedTo != null)
//        {
//            line.SetPosition(0, current.position);
//            line.SetPosition(1, connectedTo.position);
//        }


//        // //cannot grab wire in simulation mode
//        // if(simulationStatus.simulationMode == false)
//        // {
//        //     gameObject.GetComponent<OVRGrabbable>().enabled = true;
//        // }
//        // else
//        // {
//        //     gameObject.GetComponent<OVRGrabbable>().enabled = false;
//        // }

//    }

//}
