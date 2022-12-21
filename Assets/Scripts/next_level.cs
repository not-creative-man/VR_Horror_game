using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next_level : MonoBehaviour
{

    public void StartGame() { 
	/*CsGlobal.teddy = false;
Debug.Log("aaaa");
	CsGlobal.tarzan = false;
	CsGlobal.waddles = false;
	CsGlobal.bonny = false;
	CsGlobal.barbie_1 = false;
	CsGlobal.CsGlobal.barbie_2 = false;
	CsGlobal.cubes = false;
	CsGlobal.last = false;*/
        SceneManager.LoadScene("Game");
    }
    
    public void Exit() {
        Application.Quit(); 
    }
}