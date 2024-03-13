using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DrumSounds : MonoBehaviour
{

    [SerializeField] private UnityEvent myEvent;

    // Start is called before the first frame update
    void Start()
    {
        myEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
