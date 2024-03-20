using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AttackZone : MonoBehaviour
{

    public int EnemyCount;
    bool moreEnemies = true;
    [SerializeField] private AudioMixer myMixer;

    public DrumSounds drumScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (EnemyCount == 0) // killed all enemies
        {
            drumScript.StopCombat();
            EnemyCount = 6; // this is so that it doesnt affect the next combat zone
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == NewPlayer.Instance.gameObject) // when player enters
        {

            myMixer.SetFloat("AmbientLp", 1288f);
            myMixer.SetFloat("RunningLp", 1288f);
        }
        
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject == NewPlayer.Instance.gameObject) // player left the zone 
        {

            drumScript.StopCombat();
            myMixer.SetFloat("AmbientLp", 22000f);
            myMixer.SetFloat("RunningLp", 22000f);

        }
        

    }

    
    
}


