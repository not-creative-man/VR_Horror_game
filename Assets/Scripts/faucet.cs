using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faucet : MonoBehaviour
{
    private Animator anim;

    void Start(){
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other){
        if(other.CompareTag("player") && (Input.GetKey(KeyCode.E) || OVRInput.Get(OVRInput.Button.One))){
            anim.Play("tap_rotate");
            Debug.Log('a');
            CsGlobal.door_opened = true;
        }
    }
}
