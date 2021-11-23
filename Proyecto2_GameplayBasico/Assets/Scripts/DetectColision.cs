using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColision : MonoBehaviour
{
   private void OnTriggerEnter(Collider otherCollider)
    {
        //Destruye el proyectil
        Destroy(gameObject);

        //Destruye el objeto contra el que colisiona
        Destroy(otherCollider.gameObject);
    }
}
