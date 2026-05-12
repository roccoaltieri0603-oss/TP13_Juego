using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement CajaMovementScript;

    // Cantidad de velocidad que aumenta cada vez
    public float aumentoVelocidad = 1f;

    void Start()
    {
        CajaMovementScript = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Piso"))
        {
            // Aumentar velocidad
            CajaMovementScript.caida += aumentoVelocidad;

            // Mover la caja arriba otra vez
            CajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}