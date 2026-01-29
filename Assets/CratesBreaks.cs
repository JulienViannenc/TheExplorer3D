using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratesBreaks : MonoBehaviour
{
    public AK.Wwise.Event AS_CratesBreaks;

    // Cette fonction DOIT être public et ne prendre AUCUN paramètre
    public void PlayBreakSound() // Nouveau nom plus simple
    {
        AS_CratesBreaks.Post(gameObject);
    }
}