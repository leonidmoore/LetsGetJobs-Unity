using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeOnLoad : MonoBehaviour
{
    public Button optionBtn1;
    public Button optionBtn2;
    public Button optionBtn3;
    public Button optionBtn4;
    public Button optionBtn5;
    public Button optionBtn6;
    public Button optionBtn7;
    public Button optionBtn8;

    public Text optionBtnTxt1;
    public Text optionBtnTxt2;
    public Text optionBtnTxt3;
    public Text optionBtnTxt4;
    public Text optionBtnTxt5;
    public Text optionBtnTxt6;
    public Text optionBtnTxt7;
    public Text optionBtnTxt8;
    public Text title;

    void Start()
    {
        GameObject MajorManager = GameObject.Find("MajorManager");
        MajorTracking majorTracking = MajorManager.GetComponent<MajorTracking>();

        GameObject Title = GameObject.Find("Title");
        FadeInOutText fadeInOutText = Title.GetComponent<FadeInOutText>();
        //Major 2
        if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 2)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You’ve just declared your major in your University with hopes of becoming a Harware Engineer! What 4 classes out of the following should you take to prepare you for your future roles?";
            optionBtnTxt1.GetComponent<Text>().text = "Human-computer interaction";
            optionBtnTxt2.GetComponent<Text>().text = "E-Commerce";
            optionBtnTxt3.GetComponent<Text>().text = "Workstation programming";
            optionBtnTxt4.GetComponent<Text>().text = "Multimedia databases";
            optionBtnTxt5.GetComponent<Text>().text = "Digital computer systems";
            optionBtnTxt6.GetComponent<Text>().text = "Cryptography and cryptanalysis";
            optionBtnTxt7.GetComponent<Text>().text = "Principles of robotics";
            optionBtnTxt8.GetComponent<Text>().text = "Operations management";
        }
        
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 2)
        {
            optionBtnTxt1.GetComponent<Text>().text = "3D design using Computer Aided Design software";
            optionBtnTxt2.GetComponent<Text>().text = "Data collection and management";
            optionBtnTxt3.GetComponent<Text>().text = "Configuration and administration of VoIP network systems";
            optionBtnTxt4.GetComponent<Text>().text = "Software development with Java";
            optionBtnTxt5.GetComponent<Text>().text = "Full stack web development";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 2)
        {
            optionBtnTxt1.GetComponent<Text>().text = "Writing a calculator in Java";
            optionBtnTxt2.GetComponent<Text>().text = "Unity game project";
            optionBtnTxt3.GetComponent<Text>().text = "Research Involving Data Science";
            optionBtnTxt4.GetComponent<Text>().text = "React.js App";
            optionBtnTxt5.GetComponent<Text>().text = "Weather app";
        }

        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 2)
        {
            title.GetComponent<Text>().text = "You want to polish up on some  recommended skills before you start applying. What do you want to do?";
            optionBtnTxt1.GetComponent<Text>().text = "Relearn essential math and physics";
            optionBtnTxt2.GetComponent<Text>().text = "Optimize my current PC Build";
            optionBtnTxt3.GetComponent<Text>().text = "Research current trends in technology and electronics";
            optionBtnTxt4.GetComponent<Text>().text = "Start learning some web-based technologies";
        }

        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 2)
        {
            title.GetComponent<Text>().text = "How do you stay up to date with the latest industry trends? (Specific)";
            optionBtnTxt1.GetComponent<Text>().text = "I attend nearby engineering events//expos whenever possible";
            optionBtnTxt2.GetComponent<Text>().text = "I look for the latest leaks/rumors on the internet";
            optionBtnTxt3.GetComponent<Text>().text = "I follow a few of the big players like Intel / AMD via Social Media";
            optionBtnTxt4.GetComponent<Text>().text = "I pay attention to the latest industry news";
            optionBtn5.gameObject.SetActive(false);
            optionBtn6.gameObject.SetActive(false);
            optionBtn7.gameObject.SetActive(false);
            optionBtn8.gameObject.SetActive(false);
        }
    }
}
