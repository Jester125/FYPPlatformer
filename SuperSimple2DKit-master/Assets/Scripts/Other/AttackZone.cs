using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == NewPlayer.Instance.gameObject)
        {
            
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("CombatVol", 1f);
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject == NewPlayer.Instance.gameObject)
        {
           
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("CombatVol", 0f);
            FMODUnity.RuntimeManager.StudioSystem.setParameterByName("CombatBreak", 0f);
        }

    }
}
