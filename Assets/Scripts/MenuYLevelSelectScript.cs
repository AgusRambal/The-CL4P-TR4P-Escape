using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuYLevelSelectScript : MonoBehaviour
{
    public Button level02Button, level03Button, playButton, levelSelectButton, backToMenu;
    int levelPassed;
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = true;
        level03Button.interactable = false;
        playButton.interactable = true;
        levelSelectButton.interactable = true;
        backToMenu.interactable = true;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = true;
        level03Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
