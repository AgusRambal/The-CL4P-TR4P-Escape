using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideDeath : MonoBehaviour
{
    public Collider2D myCollider;

    public float minTime;
    public float maxTime;
    public float timer;
    void Start()
    {
        timer = Time.time;
    }

    void Update()
    {
        DeathCollide();
    }

    void DeathCollide()
    {
        if (Time.time - timer > 1)
        {
            myCollider.enabled = !myCollider.enabled;
            timer = Time.time;
        }
    }
}
