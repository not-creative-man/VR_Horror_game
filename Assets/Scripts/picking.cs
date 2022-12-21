using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picking : MonoBehaviour
{
    private void OnTriggerStay(Collider other){
        //Debug.Log("sheeeeet");
        if(other.CompareTag("player") && (Input.GetKey(KeyCode.E) || OVRInput.Get(OVRInput.Button.One))){
            switch (gameObject.tag)
            {
                case "flashlight":{
                    CsGlobal.flashLight_enabled = true;
                    Debug.Log("FlashLight equiped: " + CsGlobal.flashLight_enabled);
                    break;
                };
                case "teddy":{
                    CsGlobal.teddy = true;
                    Debug.Log("Teddy equiped: " + CsGlobal.teddy);
                    break;
                };
                case "tarzan":{
                    CsGlobal.tarzan = true;
                    Debug.Log("Tarzan equiped: " + CsGlobal.tarzan);
                    break;
                };
                case "bonny":{
                    CsGlobal.bonny = true;
                    Debug.Log("Bonny equiped: " + CsGlobal.bonny);
                    break;
                };
                case "waddles":{
                    CsGlobal.waddles = true;
                    Debug.Log("Waddles equiped: " + CsGlobal.waddles);
                    break;
                };
                case "barbie_1":{
                    CsGlobal.barbie_1 = true;
                    Debug.Log("Barbie_1 equiped: " + CsGlobal.barbie_1);
                    break;
                };
                case "barbie_2":{
                    CsGlobal.barbie_2 = true;
                    Debug.Log("Barbie_2 equiped: " + CsGlobal.barbie_2);
                    break;
                };
                case "cubes":{
                    CsGlobal.cubes = true;
                    Debug.Log("Cubes equiped: " + CsGlobal.cubes);
                    break;
                };
            };
            Destroy(gameObject);
        }
    }
}
