using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void restarScene1()
    {
        SceneManager.LoadScene("Level1");
        TimeController.instance.EndTime();
        StepsCounter.stepsValue = 0;
    }
    public void SiguienteNivel()
    {
        SceneManager.LoadScene("Level2");
        TimeController.instance.EndTime();
        StepsCounter.stepsValue = 0;
    }

    public void restarScene2()
    {
        SceneManager.LoadScene("Level2");
        TimeController.instance.EndTime();
        StepsCounter.stepsValue = 0;
    }
}
