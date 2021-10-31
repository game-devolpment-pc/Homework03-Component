using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("how fast the object moves, in meters per second")]
    Vector3 v = new Vector3(1,0,0);
    
    //void setv(int x){
       // v.insert (x,0,0);
   // }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Transform t =  GetComponent<Transform>();
        //t.position += v * Time.deltaTime;
        
            
        for (int i = -9; i<10; i++){
            t.position += ( v * i ) * Time.deltaTime;
       
        }
      // for (int j = 0; j < 6; j++){
              // t.position += v.setv(j,0,0) * Time.deltaTime;
           //}
       // t.position += v * Time.deltaTime;
    }
}
