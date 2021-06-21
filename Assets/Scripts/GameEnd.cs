using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text title;
    public Button nextSceneBtn;
    public Text feedBackTextField;
    public int requiredPtsToWin;
    // Start is called before the first frame update
    void Start()
    {
        GameObject MajorManager = GameObject.Find("MajorManager");
        MajorTracking majorTracking = MajorManager.GetComponent<MajorTracking>();
        if (majorTracking.majorChoosen == 1)
        {
            requiredPtsToWin = 15;
        } 
        else if (majorTracking.majorChoosen == 2)
        {
            requiredPtsToWin = 13;
        }
        else if (majorTracking.majorChoosen == 3)
        {
            requiredPtsToWin = 13;
        }
        else if (majorTracking.majorChoosen == 4)
        {
            requiredPtsToWin = 13;
        }

        if (GlobalVariables.Instance.pts >= requiredPtsToWin)
        {
            title.text = "Yay! You got the job!";
        }
        else
        {
            title.text = "You did not get the job :(";
        }
    }
}
