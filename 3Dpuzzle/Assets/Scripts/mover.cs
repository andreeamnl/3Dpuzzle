using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();


    }

    void MovePlayer(){
        float xValue= Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //forgot why i neeed the delattime
        float zValue= Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);

    }
}
