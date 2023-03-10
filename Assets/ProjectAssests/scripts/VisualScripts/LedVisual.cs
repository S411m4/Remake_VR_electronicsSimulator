using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedVisual : MonoBehaviour
{
    [SerializeField] GameObject ledCover;
    [SerializeField] GameObject emissionObject; //for led emission at weak currents
    [SerializeField] Light ledLight;

    [SerializeField] LedBehaviour ledBehaviour;

    Animator animator;
    private const string BURN_TRIGGER = "burnt";


    private void Start()
    {
        //set led color [cover, emission, light]
        LedSO ledSO = this.transform.parent.GetComponent<LedBehaviour>().GetLedSO();
        ledCover.GetComponent<Renderer>().material = ledSO.ledColor;
        ledLight.color = ledSO.ledColor.color;
        emissionObject.GetComponent<Renderer>().material = ledSO.emissionMaterial;

        animator = GetComponent<Animator>();


        ledBehaviour.OnLedTurnedOff += LedBehaviour_OnLedTurnedOff;
        ledBehaviour.OnLedTurnedOn += LedBehaviour_OnLedTurnedOn;
        ledBehaviour.OnLedBurnt += LedBehaviour_OnLedBurnt;

        
    }

    private void LedBehaviour_OnLedBurnt(object sender, System.EventArgs e)
    {
        animator.SetTrigger(BURN_TRIGGER);
        Debug.Log("burnt");
    }

    private void LedBehaviour_OnLedTurnedOn(object sender, LedBehaviour.OnLedTurnedOnEventArgs e)
    {
        emissionObject.SetActive(true);
        Debug.Log("ledon");
    }

    private void LedBehaviour_OnLedTurnedOff(object sender, System.EventArgs e)
    {
        ledLight.intensity = 0;
        emissionObject.SetActive(false);
        Debug.Log("led off");
    }
}
