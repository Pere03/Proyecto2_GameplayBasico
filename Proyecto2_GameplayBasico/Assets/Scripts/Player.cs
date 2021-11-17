using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float turnSpeedH = 50f;
    private float turnSpeedV = 10f;
    public float horizontalInput;
    public float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");
        /*
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        */

        //Esto hace que puedas avanzar hacia delante y atras con el objeto
        transform.Translate(Vector3.forward * turnSpeedV * Time.deltaTime * verticalInput);

        //Esto hace que puedas rotar/mover hacia la izquierda y derecha con el objeto
        transform.Rotate(Vector3.up * turnSpeedH * Time.deltaTime * horizontalInput);
    }
}
