using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurn : MonoBehaviour;
  { 
    public float cameraSpeed = 2f;

}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.RightArrow) == true) { this.transform.position += this.transform.forward * Time.deltaTime * this.cameraSpeed; }
    if (Input.GetKey(KeyCode.LeftArrow) == true) { this.transform.position -= this.transform.forward * Time.deltaTime * this.cameraSpeed; }
}
