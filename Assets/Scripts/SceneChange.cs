using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button optionBtn;
    public FeedBack feedBack;

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
            GameObject FeedBackManager = GameObject.Find("FeedBackTracking");
            FeedBack feedBack = FeedBackManager.GetComponent<FeedBack>();
            FeedBack feedBackList = FeedBackManager.GetComponent<FeedBack>();
            feedBack.feedBackList.Clear();
            GlobalVariables.Instance.pts = 0;
            //btnManager.Reset();
            SceneManager.LoadScene("GameMenu");
        }
        else if (SceneManager.GetActiveScene().name == "Settings")
        {
            SceneManager.LoadScene("GameMenu");
        }
    } 
}
