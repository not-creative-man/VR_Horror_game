using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slender_hiding : MonoBehaviour
{

    public GameObject slender;
    public GameObject mirror;
    public Light light;
    public Light light_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float int_1 = light.GetComponent<Light>().intensity;
        float int_2 = light_2.GetComponent<Light>().intensity;
        if(int_1 + int_2 > 0 && int_1 + int_2 < 1.3){
            mirror.SetActive(false);
            slender.SetActive(true);
        }
        else{
            mirror.SetActive(true);
            slender.SetActive(false);
        }
    }
}
