using UnityEngine;
using System;

public class LedBehaviour : MonoBehaviour
{
    private LedSO ledSO;

    [Serializable] enum LedState
    {On, Off, Burnt };

    [SerializeField] LedState ledState;
    [SerializeField] float VoltSource;

    public event EventHandler<OnLedTurnedOnEventArgs> OnLedTurnedOn;
    public class OnLedTurnedOnEventArgs : EventArgs
    { public float ledEmission; }

    public event EventHandler OnLedTurnedOff;
    public event EventHandler OnLedBurnt;

    private void Awake()
    {
        ledState = LedState.Off;
    }



    private void Update() //update runs too fast (it executes but visuals don't take its time)
    {
        switch(ledState)
        {
            case LedState.On:
                float ledEmission = (VoltSource - ledSO.voltDrop_Volts).Map(0, VoltSource, 0, 1);
                OnLedTurnedOn?.Invoke(this, new OnLedTurnedOnEventArgs { ledEmission = ledEmission });
                break;

            case LedState.Off: //either not connected or not enough volt
                OnLedTurnedOff?.Invoke(this, EventArgs.Empty);
                break;

            case LedState.Burnt:
                OnLedBurnt?.Invoke(this, EventArgs.Empty);
                break;
        }
    }



    public void SetLedSO(LedSO ledSO)
    {
        this.ledSO = ledSO;
    }
    public LedSO GetLedSO()
    {
        return ledSO;
    }
}
