using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject Balle;


    public void Move (Vector2 moveTo)
    {
        direction = moveTo;
        rb.velocity = new Vector3(direction.x, 0, direction.y);
    }

    //Instantiate = faire apparaitre un objet\\
    public void SpawnABalle()
    {
        Instantiate(Balle, transform.position + transform.forward * 2f, Quaternion.identity);
    }
}
