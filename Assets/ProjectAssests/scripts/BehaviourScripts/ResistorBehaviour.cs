using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResistorBehaviour : ResistorBase
{
    private ResistorSO resistorSO;
    private void Awake()
    {
        Behaviour();
    }

    public void SetResistorSO(ResistorSO resistorSO)
    {
        this.resistorSO = resistorSO;
    }
    
    public ResistorSO GetResistorSO()
    {
        return resistorSO;
    }
}
