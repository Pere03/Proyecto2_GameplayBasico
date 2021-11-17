using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private float HorizontalInput;
    public float Speed = 10;
    public float xRange = 16;
    public float xRangeInv = -16;


    void Start()
    {
        
    }

   
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * HorizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

    }
}
