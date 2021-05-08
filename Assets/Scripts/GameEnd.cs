using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text title;
    public Button nextSceneBtn;
    public Text feedBackTextField;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariables.Instance.pts >= 15)
        {
            title.text = "Yay! You got the job!";
        }
        else
        {
            title.text = "You did not get the job :(";
        }
    }
}
