using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSideMovement : MonoBehaviour {
    public float speed = 32;
    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update 
        () {
        float mov = Input.GetAxis("Horizontal"); //obtener tecla
        transform.Translate(Vector3.right * mov * speed * Time.deltaTime); //mover al pj

        this.GetComponent<SpriteRenderer>().flipX = mov < 0f; //relfejar la imagen
        if (mov == 0)
        {
            anim.Play("idle");
        }
        else
        {
            anim.Play("running");
        }
       

	}
}
