using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPressurePlate : MonoBehaviour
{
    public GameObject roland;

    void Start()
    {
        roland.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Piston"))
        {
            roland.SetActive(true);
            Debug.Log("entra");
        }
    }
}
