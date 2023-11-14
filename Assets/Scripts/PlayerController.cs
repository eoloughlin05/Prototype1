using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera cameraOne;
    public Camera cameraTwo;
    public KeyCode cameraSwitchKey;

    public string playerID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + playerID);
        forwardInput = Input.GetAxis("Vertical" + playerID);
        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(cameraSwitchKey))
        {
            cameraOne.enabled = !cameraOne.enabled;
            cameraTwo.enabled = !cameraTwo.enabled;
        }


    }
}
