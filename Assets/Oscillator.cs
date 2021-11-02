using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("how fast the object moves, in meters per second")]
    Vector3 speed = new Vector3(20,0,0);
    
    //float fl =(float) (Math.Sin( 90 ));
    float ss = 0f;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Transform t =  GetComponent<Transform>();
        t.position +=( speed * (float)(Math.Sin((ss+=0.2f)* (Math.PI)/ 180))) * Time.deltaTime ;
    }
}
