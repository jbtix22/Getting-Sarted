using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public float rotateSpeed; 
    
    // Use this for initialization
    void Start () {
        int flipon = 1;{

        }
    }
    
    // Update is called once per frame
    void Update () {
        int flipon = 1;{

        }

        flipon = 1;

        if(Input.GetKeyDown("space"))
            while (flipon == 1)
                transform.Rotate(10,0,0);
                
            
    }
}
