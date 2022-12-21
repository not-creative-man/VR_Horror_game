using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class following : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] float _velocity = 10;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if(dist < 6){
            anim.Play("Slender_move");
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * _velocity);
        }
        else{
            anim.Play("Slender");
        }
    }
}