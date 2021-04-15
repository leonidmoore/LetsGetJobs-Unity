using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplaceEverything : MonoBehaviour
{
    public Button optionBtn1;
    public Button optionBtn2;
    public Button optionBtn3;
    public Button optionBtn4;

    public Text optionBtnTxt1;
    public Text optionBtnTxt2;
    public Text optionBtnTxt3;
    public Text optionBtnTxt4;

    public Text title;
    public int count;

    public void OnClick()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        CountTracking countTracking = GameManager.GetComponent<CountTracking>();
        if (countTracking.count == 0)
        {
            title.GetComponent<Text>().text = "Some time passes as you do your applications, you eventually feel the need to brush up on what you learned. What do you do?";

            optionBtnTxt1.GetComponent<Text>().text = "Take on one more project to kill time";
            optionBtnTxt2.GetComponent<Text>().text = "Enhance one of your completed projects";
            optionBtnTxt3.GetComponent<Text>().text = "Take a much needed break.";
            optionBtnTxt4.GetComponent<Text>().text = "Wait patiently for someone to contact you on LinkedIn.";
            countTracking.count++;
        }

        else if (countTracking.count == 1)
        {

            title.GetComponent<Text>().text = "Now comes the part where you prepare your resume, but you have so much information that will no doubt help you stand out. What do you do?";
            optionBtnTxt1.GetComponent<Text>().text = "Customize your resume to have some information related to the job";
            optionBtnTxt2.GetComponent<Text>().text = "Have all your best achievements on there! Go hard or go home";
            optionBtn3.gameObject.SetActive(false);
            optionBtn4.gameObject.SetActive(false);
            countTracking.count++;
        }
    }
}
