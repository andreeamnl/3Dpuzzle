using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    //not sure why we deleted start and update function 
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped");
        GetComponent<MeshRenderer>().material.color=Color.red;
    }
    
}
