using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FeedBack : MonoBehaviour
{
    public string feedBack;
    public Text title;
    public Text feedBackText;

    void Start()
    {
        Debug.Log(feedBack);
        if (SceneManager.GetActiveScene().name == "GameEnd")
        {
            feedBackText.text = feedBack;
            if (GlobalVariables.Instance.pts >= 15)
            {
                title.text = "Yay! You got the Job!";
            }
            else
            {
                title.text = "You did not get the Job :(";
            }
        }
    }
}
