using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NewBehaviourScript : MonoBehaviour {

    private Animator anim = null;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d"))
        {
            anim.SetBool("keyRight1", false);
            anim.SetBool("keyRight" , true);
        }
        if (Input.GetKeyUp("d"))
        {
            anim.SetBool("keyRight", false);
            anim.SetBool("keyRight1", true);
        }
        if (Input.GetKeyDown("a"))
        {
            anim.SetBool("keyLeft1", false);
            anim.SetBool("keyLeft", true);
        }
        if (Input.GetKeyUp("a"))
        {
            anim.SetBool("keyLeft", false);
            anim.SetBool("keyLeft1", true);
        }
    }


}
