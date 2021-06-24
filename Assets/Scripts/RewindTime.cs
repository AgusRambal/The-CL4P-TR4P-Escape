using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindTime : MonoBehaviour
{
    public bool isRewinding = false;

    List<PointInTime> pointsInTime = new List<PointInTime>();

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartRewind();
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            StopRewind();
        }
    }

    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Rewind()
    {
        if (pointsInTime.Count>0)
        {
           SetPointInTime(pointsInTime[pointsInTime.Count - 1]);
           pointsInTime.RemoveAt(pointsInTime.Count -1);
        }
        else
        {
            StopRewind();
        }
        
    }

    void Record()
    {
        PointInTime timePoint = new PointInTime(transform.position, rb.velocity);
        pointsInTime.Add(timePoint);
    }

    public void StartRewind()
    {
        isRewinding = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
    }

    void SetPointInTime(PointInTime timePoint)
    {
        this.transform.position = timePoint.Position;
        rb.velocity = timePoint.Velocity;
    }

}
