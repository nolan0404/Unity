using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject Balle;
    [SerializeField] private float mouvementSpeed = 10;
    [SerializeField] private GameObject lastball;
    [SerializeField] private Transform playerTransform;
    private float xRotation;


    public void Move (Vector2 moveTo)
    {
        // Définit la vitesse du personnage\\
        direction = moveTo;
        rb.velocity = new Vector3(direction.x, 0, direction.y);
        rb.velocity = new Vector3(direction.x * mouvementSpeed, rb.velocity.y, direction.y * mouvementSpeed);

        //Permet au personnage de courir et de tirer en meme temps\\
        Vector3 forward = transform.forward;
        forward.y = 0;
        rb.velocity = new Vector3(direction.x,0,direction.y)*mouvementSpeed;
    }

    //Instantiate = faire apparaitre un objet\\
    public void SpawnABalle()
    {
        lastball = Instantiate(Balle, transform.position + transform.forward * 1f, Quaternion.identity);
        lastball.GetComponent<Balle>().direction = transform.forward;
    }

    //Permet au personnage de se tourner

    private void GetRotation()
    {
        if (Vector2.zero != direction)
        {
            transform.LookAt(transform.position + new Vector3(direction.x, 0, direction.y));
        }
    }

    private void Update()
    {
        GetRotation();
    }
}
