using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {

        GetComponent<MeshRenderer>().material.color = Color.red;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Vector3.right * Time.deltaTime);
        }


    }
}
