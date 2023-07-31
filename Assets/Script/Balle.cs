using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    [SerializeField] private float balleSpeed = 30;
    [SerializeField] private Rigidbody balle;
    public Vector3 direction;

    private void FixedUpdate()
    {
        balle.velocity = direction * balleSpeed;
    }

}

