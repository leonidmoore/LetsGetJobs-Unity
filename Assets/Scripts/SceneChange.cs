using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    } 
}
