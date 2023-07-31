using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    void Update()
    {
        // Player2 için hareket kontrolleri
        float horizontalInput = Input.GetAxis("Horizontal2");
        float verticalInput = Input.GetAxis("Vertical2");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;

        GetComponent<Rigidbody>().velocity = moveVelocity;

        // Player2 için ateþ etme
        if (Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Player2 için mermi oluþturma ve atýþ iþlemleri
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = firePoint.forward * bulletSpeed;
    }
}
