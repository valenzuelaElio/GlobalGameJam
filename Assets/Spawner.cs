using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject toInstantiate;

    public bool Move;
    public int Speed;

    public float delta = 1.5f;  // Amount to move left and right from the start point
    private Vector3 startPos;

    private float startTime, timesTamp;
    public float toAppearTime;

    void Start()
    {
        startPos = transform.position;
        startTime = Time.time;
    }

    void Update()
    {

        if (Move)
        {
            Vector3 v = startPos;
            v.x += delta * Mathf.Sin(Time.time * Speed);
            transform.position = v;
        }

        timesTamp = Time.time - startTime;
        if (timesTamp >= toAppearTime)
        {
            Instantiate(toInstantiate, transform.position, Quaternion.identity);
            startTime = Time.time;
        }
        

    }
}
