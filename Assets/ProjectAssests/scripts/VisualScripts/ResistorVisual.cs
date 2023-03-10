using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistorVisual : MonoBehaviour
{
    
    [SerializeField] GameObject no1Band;
    [SerializeField] GameObject no2Band;
    [SerializeField] GameObject multiplierBand;

    private void Start()
    {
        ResistorSO resistorSO = this.transform.parent.GetComponent<ResistorBehaviour>().GetResistorSO();

        no1Band.GetComponent<Renderer>().material = resistorSO.band1Color;
        no2Band.GetComponent<Renderer>().material = resistorSO.band2Color;
        multiplierBand.GetComponent<Renderer>().material = resistorSO.multiplierBandColor;


    }







}
