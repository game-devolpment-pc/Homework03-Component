//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandshwo : MonoBehaviour
{
    [SerializeField]
    [Tooltip(" ### ")]
    float step = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Transform t =  GetComponent<Transform>();
        Renderer rend = gameObject.GetComponent<Renderer>();
        if  (Input.GetKeyDown("space")){
            if(rend.enabled) rend.enabled = false;
            else rend.enabled = true;
        }
    }
}
