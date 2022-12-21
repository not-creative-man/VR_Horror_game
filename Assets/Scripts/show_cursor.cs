using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_cursor : MonoBehaviour
{
    private bool cur = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update () {
        /*if (Input.GetKeyDown(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
        }
        Cursor.visible = true;*/
    }
}