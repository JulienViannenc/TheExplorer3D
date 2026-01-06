using System;
using UnityEngine;

public class CS_AudioColliderTrigger3D : MonoBehaviour
{

    public AK.Wwise.Event onEnterEvent;
    public AK.Wwise.Event onExitEvent;
    public GameObject gameObjectAudioTarget;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onEnterEvent.Post(gameObjectAudioTarget);
        }
    }
    
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onExitEvent.Post(gameObjectAudioTarget);
        }
    }
}
