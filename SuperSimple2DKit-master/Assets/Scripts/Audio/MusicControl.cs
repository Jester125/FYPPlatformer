using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{

    //[FMODUnity.EventRef]
    //FMODUnity.EventReference;
    public string foley = "event:/Foley/FoleySounds";
    public string ambient = "event:/Ambient/Ambient";
    public string run = "event:/Running/Run";




    FMOD.Studio.EventInstance FoleyEv;
    FMOD.Studio.EventInstance AmbientEv;
    FMOD.Studio.EventInstance RunEv;

    // Start is called before the first frame update
    void Start()
    {
        //FoleyEv.EventReference = FMODUnity.RuntimeManager.PathToEventReference(foley);
        FoleyEv = FMODUnity.RuntimeManager.CreateInstance(foley);
        AmbientEv = FMODUnity.RuntimeManager.CreateInstance(ambient);
        RunEv = FMODUnity.RuntimeManager.CreateInstance(run);

        FoleyEv.start();
        AmbientEv.start();
        RunEv.start();
    }

    public void setRun ()
    {
        //RunEv.setParameterValue("RunVol", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
