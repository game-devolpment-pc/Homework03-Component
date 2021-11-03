using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Oscillator : MonoBehaviour
{
     private float distance = 10f;
    [Tooltip("speed of the object")]
    [SerializeField] private float speed = 1f;

     void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = new Vector3(Mathf.Sin(Time.time * speed) * distance, 0, 0);
    }
}
