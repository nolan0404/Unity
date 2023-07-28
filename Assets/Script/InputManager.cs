using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerControler pc;
    [SerializeField] private int noOfPlayer;
    private Vector2 direction;

    private void GetDirection()
    {
        direction.x = Input.GetAxis("HorizontalP" + noOfPlayer);
        direction.y = Input.GetAxis("VerticalP" + noOfPlayer);
    }
    //noOfPlayer veut dire l'un des joueurs\\


    void Update()
    {
        GetDirection();
        pc.Move(direction);

        if (Input.GetButtonDown("Fire1P" + noOfPlayer))
        {
            pc.SpawnABalle();
        }
    }
    }

