using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepsCounter : MonoBehaviour
{
    public Text Steps;
    public static int stepsValue;

    void Start()
    {
        Steps = GetComponent<Text>();

    }

    void Update()
    {
        Steps.text = "Pasos: " + stepsValue;
    }
}
