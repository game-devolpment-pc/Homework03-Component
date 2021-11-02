using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("how fast the object moves, in meters per second")]
    Vector3 v = new Vector3(20,0,0);
    
    //float fl =(float) (Math.Sin( 90 ));
    float ss = 0f;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Transform t =  GetComponent<Transform>();
        //t.position += v * new Vector3((float) (Math.Sin((ss++) * (Math.PI) / 180)),0,0) * Time.deltaTime;
        t.position +=( v * (float)(Math.Sin((ss+=0.2f)* (Math.PI)/ 180))) * Time.deltaTime ;
    }
}
