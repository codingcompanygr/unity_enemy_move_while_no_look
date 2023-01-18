using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Player;

    public float speed = 10f;

    public bool CanMove;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (CanMove)
        {
            Move();
        }
        else
        {
            Stop();
        }

        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }

    void Move()
    {
        speed = 10f;
    }

    void Stop()
    {
        speed = 0f;
    }
}
