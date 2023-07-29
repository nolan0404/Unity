using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    [SerializeField] private float balleSpeed = 30;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Nesneyi ileri doðru (z ekseninde) hareket ettirme
        rb.velocity = transform.forward * balleSpeed;
    }
}