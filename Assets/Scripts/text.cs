using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public GameObject text_on_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CsGlobal.bonny && CsGlobal.waddles){
	        //Debug.Log("sheet");
	        transform.position = new Vector3(4.263f, 2.149f, 0.352f);
	    }
    }
}
