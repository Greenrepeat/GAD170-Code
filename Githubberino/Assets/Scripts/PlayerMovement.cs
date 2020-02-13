using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 

    public float moveSpeed = 5f;
    public float turnSpeed = 100f;
    public float jumpSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey( KeyCode.W ) == true ) {   moveSpeed;  }
        if( Input.GetKey( KeyCode.S ) == true ) { this.transform.position -= this.transform.forward * Time.deltaTime * this.moveSpeed;  }

        if( Input.GetKey( KeyCode.D ) == true ) { this.transform.Rotate(this.transform.up, Time.deltaTime * this.turnSpeed);  }
        if( Input.GetKey( KeyCode.A ) == true ) { this.transform.Rotate(this.transform.up, Time.deltaTime * -this.turnSpeed); }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;
        }


    }
}
