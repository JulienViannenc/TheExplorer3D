using System;
using UnityEngine;

public class CS_AudioSwitch : MonoBehaviour
{

    public AK.Wwise.Switch switchTarget;
    public GameObject gameObjectAudioTarget;

    public void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) {
        switchTarget.SetValue(gameObjectAudioTarget);
        Debug.Log("Trigger");
        }
    }
}
