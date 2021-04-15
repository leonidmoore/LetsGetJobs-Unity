using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "GameMenu")
        {
            SceneManager.LoadScene("Intro");
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
    } 
}
