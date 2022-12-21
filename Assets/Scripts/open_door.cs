using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour
{
    private Animator anim;
    public AudioClip open_door_to_another_world;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
	//audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        if(CsGlobal.door_opened){
            //Debug.Log("Door opened");
            gameObject.GetComponent<BoxCollider>().enabled = false;
            anim.Play("door_open");
            //audio.PlayOneShot(open_door_to_another_world, 0.7F);
        }
    }
}
