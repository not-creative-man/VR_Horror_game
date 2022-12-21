using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_from_player : MonoBehaviour
{

    public Light flash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CsGlobal.flashLight_enabled){
            if(Input.GetKey(KeyCode.F) || OVRInput.Get(OVRInput.Button.Two)){
                flash.enabled = !flash.enabled;
            }
        }
    }
}
