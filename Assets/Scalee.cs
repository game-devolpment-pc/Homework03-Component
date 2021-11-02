//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scalee : MonoBehaviour
{
    float ss= 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(1,1,0) * (float)(Math.Sin((ss+=0.2f)* (Math.PI)/ 180)) * Time.deltaTime;
    }
}
