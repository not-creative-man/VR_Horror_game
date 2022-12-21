using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    private bool ted, bon, tar, wad, b_1, b_2, cub;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ted = CsGlobal.teddy;
        bon = CsGlobal.bonny;
        tar = CsGlobal.tarzan;
        wad = CsGlobal.waddles;
        b_1 = CsGlobal.barbie_1;
        b_2 = CsGlobal.barbie_2;
        cub = CsGlobal.cubes;
        Debug.Log(ted + " " + bon + " " + tar + " " + wad + " " + b_1 + " " + b_2 + " " + cub);
        if(ted && bon && tar && wad && /*b_1 && b_2 &&*/ cub){
            //Debug.Log("fff");
            SceneManager.LoadScene("Win");
	    CsGlobal.last = true;
        }
    }
}
