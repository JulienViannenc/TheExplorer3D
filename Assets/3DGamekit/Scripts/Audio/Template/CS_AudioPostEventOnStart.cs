using UnityEngine;

public class CS_AudioPostEventOnStart : MonoBehaviour
{
    
    [Header("AUDIO")] 
    public GameObject audioSource;
    public AK.Wwise.Event MC_LASERGUNATTACK;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MC_LASERGUNATTACK.Post(audioSource);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
