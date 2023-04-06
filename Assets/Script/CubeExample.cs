using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExample : MonoBehaviour
{
    //Debug.Log("Collision" + 1)
    void OnCollisionEnter(Collision collision)

    
    {
        int collisionCount = 10;
        collisionCount = collisionCount + 1;
        Debug.Log("Collision");
        print( + 1);
        collisionCount += 1;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
