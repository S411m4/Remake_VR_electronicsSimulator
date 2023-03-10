using UnityEngine;


[CreateAssetMenu()]
public class ResistorSO : ScriptableObject
{
    public string name;
    public GameObject prefab;
    public Sprite image;
    public int ResistorValueOhm;

    public Material band1Color;
    public Material band2Color;
    public Material multiplierBandColor;
}
