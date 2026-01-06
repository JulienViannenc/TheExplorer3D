using System;
using UnityEngine;

public class CS_AudioColliderTrigger2D : MonoBehaviour
{

    public AK.Wwise.Event onEnterEvent;
    public AK.Wwise.Event onExitEvent;
    public GameObject gameObjectAudioTarget;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        onEnterEvent.Post(gameObjectAudioTarget);
    }
    
    public void OnTriggerExit2D(Collider2D collision)
    {
        onExitEvent.Post(gameObjectAudioTarget);
    }
}
