using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExample : MonoBehaviour
{
    //Debug.Log("Collision" + 1)
    void OnCollisionEnter(Collision collision)

    {
        int count = 10;
        count = count + 1;
        Debug.Log("Collision");
        print( + 1);
        count++;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
