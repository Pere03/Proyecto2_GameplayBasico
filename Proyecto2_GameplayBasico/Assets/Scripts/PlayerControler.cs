using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private float HorizontalInput;
    public float Speed = 10;
    public float xRange = 16;
    public float xRangeInv = -16;

    public GameObject projectilPrefab;

    void Start()
    {
        
    }

   
    void Update()
    {
        //Moverse Horizontalmente
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * HorizontalInput);

        //Pared Invisible
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        
        if (transform.position.x < xRangeInv)
        {
            transform.position = new Vector3(xRangeInv, transform.position.y,
                transform.position.z);
        }

        /*
        if (transform.position.x < -xRange) 
        { 
            tranform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }
        */

        //Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position,
                projectilPrefab.transform.rotation);
        }


   

    }
}
    