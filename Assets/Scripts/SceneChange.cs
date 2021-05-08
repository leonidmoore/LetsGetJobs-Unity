using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button optionBtn;
    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "GameMenu")
        {
            if (optionBtn.name == "Settings")
            {
                SceneManager.LoadScene("Settings");
            }
            else if (optionBtn.name == "StartGameBtn")
            {
                SceneManager.LoadScene("Intro");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Intro")
        {
            SceneManager.LoadScene("ChooseMajor");
        }
        else if (SceneManager.GetActiveScene().name == "ChooseMajor")
        {
            SceneManager.LoadScene("ChooseClasses");
        }
        else if (SceneManager.GetActiveScene().name == "ChooseClasses")
        {
            SceneManager.LoadScene("ChooseInternship");
        }
        else if (SceneManager.GetActiveScene().name == "ChooseInternship")
        {
            SceneManager.LoadScene("ChooseProject");
        }
        else if (SceneManager.GetActiveScene().name == "ChooseProject")
        {
            SceneManager.LoadScene("Preparation");
        }
        else if (SceneManager.GetActiveScene().name == "Preparation")
        {
            SceneManager.LoadScene("Interview");
        }
        else if (SceneManager.GetActiveScene().name == "GameEnd")
        {
            SceneManager.LoadScene("GameMenu");
        }
        else if (SceneManager.GetActiveScene().name == "Settings")
        {
            SceneManager.LoadScene("GameMenu");
        }
    } 
}
