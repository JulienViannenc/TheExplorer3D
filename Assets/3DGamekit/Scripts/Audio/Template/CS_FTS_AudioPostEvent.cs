using UnityEngine;

public class CS_AudioPostEvent : MonoBehaviour
{
    
    public GameObject audioSource;
    
    
    [Header("MOUVEMENT")]
    public AK.Wwise.Event MC_FT_RUN;
    public AK.Wwise.Event MC_FT_JUMP;
    public AK.Wwise.Event MC_FT_LAND;


    [Header("ATTACK")] 
    public AK.Wwise.Event MC_ATTACK_MELEE;

    public void SFX_MC_FT_RUN_Play()
    {
        MC_FT_RUN.Post(audioSource);
    }
    
    public void SFX_MC_FT_JUMP_Play()
    {
        MC_FT_JUMP.Post(audioSource);
    }
    
    public void SFX_MC_FT_LAND_Play()
    {
        MC_FT_LAND.Post(audioSource);
    }
    
    public void SFX_MC_ATTACK_MELEE_Play()
    {
        MC_ATTACK_MELEE.Post(audioSource);
    }
    
}
