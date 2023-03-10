using System;
using UnityEngine;



public class ComponentContainer: MonoBehaviour
{
    //ToThinkAbout: 1. multipleContainers for multipleObjects or user choose object to get from one common container
    //that's why you made it using getter and switch case for all component

    [SerializeField] LedSO ledSO; //for testing
    [SerializeField] ResistorSO resistorSO; //for testing

    private void Update()
    { //testing
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateSO(resistorSO);
            InstantiateSO(ledSO);
        }
    }

    private void InstantiateSO(ResistorSO resistorSO)
    {
        GameObject instantiatedObject = Instantiate(resistorSO.prefab);
        instantiatedObject.GetComponent<ResistorBehaviour>().SetResistorSO(resistorSO);
        
    }

    private void InstantiateSO(LedSO ledSO)
    {
        GameObject instantiatedObject = Instantiate(ledSO.prefab);
        instantiatedObject.GetComponent<LedBehaviour>().SetLedSO(ledSO);


    }




}
