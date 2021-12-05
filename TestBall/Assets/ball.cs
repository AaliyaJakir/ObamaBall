using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal is automatically put as A,D,left or right arrow
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Vertical is automatically put as W,S, up or down arrow
        float moveVertical = Input.GetAxis("Vertical");

        float moveUp = Input.GetAxis("Jump");

        //this is the vector movement (x,y,z)
        Vector3 movement = new Vector3(moveHorizontal, moveUp * 2, moveVertical);

        //this is where you add the vector movement to the rigidbody
        rb.AddForce(movement);
    }
}
