using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExample : MonoBehaviour
{
    //Debug.Log("OnCollisionEnter" + 1)
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision" + 1);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
