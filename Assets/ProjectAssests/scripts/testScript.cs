using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] DCSourceSO Battery9vSO;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject InstantiatedBattery = Instantiate(Battery9vSO.prefab);
        }
    }
}
