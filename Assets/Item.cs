﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	void Start () {
        Destroy(gameObject, 10);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

    }
}
