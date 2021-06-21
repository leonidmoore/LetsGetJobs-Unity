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
        //----------------------------------------------------------------------------Major 1--------------------------------------------------------
        if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 1)
        {
            fadeInOutText.FadeIn();
        }

        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 1)
        {
            fadeInOutText.FadeIn();
        }

        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 1)
        {
            fadeInOutText.FadeIn();
        }

        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 1)
        {
            fadeInOutText.FadeIn();
        }

        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 1)
        {
            fadeInOutText.FadeIn();
        }


        //----------------------------------------------------------------------------Major 2--------------------------------------------------------
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
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "3D design using Computer Aided Design software";
            optionBtnTxt2.GetComponent<Text>().text = "Data collection and management";
            optionBtnTxt3.GetComponent<Text>().text = "Configuration and administration of VoIP network systems";
            optionBtnTxt4.GetComponent<Text>().text = "Software development with Java";
            optionBtnTxt5.GetComponent<Text>().text = "Full stack web development";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 2)
        {
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "Writing a calculator in Java";
            optionBtnTxt2.GetComponent<Text>().text = "Unity game project";
            optionBtnTxt3.GetComponent<Text>().text = "Research Involving Data Science";
            optionBtnTxt4.GetComponent<Text>().text = "React.js App";
            optionBtnTxt5.GetComponent<Text>().text = "Weather app";
        }

        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 2)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You want to polish up on some  recommended skills before you start applying. What do you want to do? (pick 2)";
            optionBtnTxt1.GetComponent<Text>().text = "Relearn essential math and physics";
            optionBtnTxt2.GetComponent<Text>().text = "Optimize my current PC Build";
            optionBtnTxt3.GetComponent<Text>().text = "Research current trends in technology and electronics";
            optionBtnTxt4.GetComponent<Text>().text = "Start learning some web-based technologies";
        }

        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 2)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "How do you stay up to date with the latest industry trends? (pick 1)";
            optionBtnTxt1.GetComponent<Text>().text = "I attend nearby engineering events//expos whenever possible";
            optionBtnTxt2.GetComponent<Text>().text = "I look for the latest leaks/rumors on the internet";
            optionBtnTxt3.GetComponent<Text>().text = "I follow a few of the big players like Intel / AMD via Social Media";
            optionBtnTxt4.GetComponent<Text>().text = "I pay attention to the latest industry news";
            optionBtn5.gameObject.SetActive(false);
            optionBtn6.gameObject.SetActive(false);
            optionBtn7.gameObject.SetActive(false);
            optionBtn8.gameObject.SetActive(false);
        }

        //-------------------------------------------------------------------------------Major 3------------------------------------------------------
        if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 3)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You’ve just declared your major in your University with hopes of becoming a Database administrator! What 4 classes out of the following should you take to prepare you for your future roles?";
            optionBtnTxt1.GetComponent<Text>().text = "Analysis of Algorithms";
            optionBtnTxt2.GetComponent<Text>().text = "Principles of robotics";
            optionBtnTxt3.GetComponent<Text>().text = "Database systems";
            optionBtnTxt4.GetComponent<Text>().text = "Modern javascript";
            optionBtnTxt5.GetComponent<Text>().text = "System and network administration";
            optionBtnTxt6.GetComponent<Text>().text = "Theoretical computer science";
            optionBtnTxt7.GetComponent<Text>().text = "Linear algebra";
            optionBtnTxt8.GetComponent<Text>().text = "Computer graphics";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 3)
        {
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "Build or improve upon a machine learning pipeline using AWS Sagemaker";
            optionBtnTxt2.GetComponent<Text>().text = "Assembly and testing of electrical systems";
            optionBtnTxt3.GetComponent<Text>().text = "Game development using C++";
            optionBtnTxt4.GetComponent<Text>().text = "Develop or improve upon user interfaces using Javascript";
            optionBtnTxt5.GetComponent<Text>().text = "Prototyping DC power systems and RF electrical hardware";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 3)
        {
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "Personal online blog";
            optionBtnTxt2.GetComponent<Text>().text = "Create a command line text editor using Assembly language";
            optionBtnTxt3.GetComponent<Text>().text = "Analysis of MTA ridership data via public data provided by the MTA";
            optionBtnTxt4.GetComponent<Text>().text = "Adobe flash application";
            optionBtnTxt5.GetComponent<Text>().text = "Contribute to an open source project";
        }

        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 3)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You feel like your final project is not up to your personal standards and want to improve upon it, what should you do? (pick 2)";
            optionBtnTxt1.GetComponent<Text>().text = "Optimize the code and improve its efficiency";
            optionBtnTxt2.GetComponent<Text>().text = "Start a checklist of new features you want to add";
            optionBtnTxt3.GetComponent<Text>().text = "Ask your peers for suggestions";
            optionBtnTxt4.GetComponent<Text>().text = "Abandon this project and start a new one";
        }

        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 3)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "What does SQL stand for?";
            optionBtnTxt1.GetComponent<Text>().text = "Structured Query Language";
            optionBtnTxt2.GetComponent<Text>().text = "Secure Quick Logging";
            optionBtnTxt4.GetComponent<Text>().text = "Server Queue Language";
            optionBtnTxt8.GetComponent<Text>().text = "Sound Quality Label";

            optionBtn3.gameObject.SetActive(false);
            optionBtn5.gameObject.SetActive(false);
            optionBtn6.gameObject.SetActive(false);
            optionBtn7.gameObject.SetActive(false);
        }

        //-------------------------------------------------------------------------------Major 4------------------------------------------------------
        if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 4)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You’ve just declared your major in your University with hopes of becoming a Video game developer! What 4 classes out of the following should you take to prepare you for your future roles?";
            optionBtnTxt1.GetComponent<Text>().text = "Linear algebra";
            optionBtnTxt2.GetComponent<Text>().text = "Principles of robotics";
            optionBtnTxt3.GetComponent<Text>().text = "Game design and development";
            optionBtnTxt4.GetComponent<Text>().text = "Introduction to natural language processing";
            optionBtnTxt5.GetComponent<Text>().text = "Computer graphics";
            optionBtnTxt6.GetComponent<Text>().text = "Compiler construction";
            optionBtnTxt7.GetComponent<Text>().text = "Programming paradigms in C++";
            optionBtnTxt8.GetComponent<Text>().text = "Digital computer systems";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 4)
        {
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "Building FX Assets for Unity Distribution";
            optionBtnTxt2.GetComponent<Text>().text = "Full stack developer internship";
            optionBtnTxt3.GetComponent<Text>().text = "Optimize or implement standardized T-SQL code";
            optionBtnTxt4.GetComponent<Text>().text = "Analyze and diagnose incoming cyber attacks";
            optionBtnTxt5.GetComponent<Text>().text = "Development and testing of electrical devices";
        }

        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 4)
        {
            fadeInOutText.FadeIn();
            optionBtnTxt1.GetComponent<Text>().text = "Develop an e-commerce website";
            optionBtnTxt2.GetComponent<Text>().text = "Write a program using assembly language";
            optionBtnTxt3.GetComponent<Text>().text = "Create a machine learning algorithm";
            optionBtnTxt4.GetComponent<Text>().text = "Scratch game";
            optionBtnTxt5.GetComponent<Text>().text = "Create a peer to peer file sharing system";
        }

        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 4)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "You’ve decided you want to expand your network, how should you go about doing this? (pick 1)";
            optionBtnTxt1.GetComponent<Text>().text = "Go to a developer meetup";
            optionBtnTxt2.GetComponent<Text>().text = "Start connecting with people in your field on LinkedIn";
            optionBtnTxt3.GetComponent<Text>().text = "Join a community Discord for a game";
            //optionBtnTxt4.GetComponent<Text>().text = "Abandon this project and start a new one";
            optionBtn4.gameObject.SetActive(false);
        }

        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 4)
        {
            fadeInOutText.FadeIn();
            title.GetComponent<Text>().text = "Which of the following is NOT a game engine (pick 1)";
            optionBtnTxt1.GetComponent<Text>().text = "Nvidia Engine";
            optionBtnTxt2.GetComponent<Text>().text = "Unreal Engine";
            optionBtnTxt4.GetComponent<Text>().text = "Godot Engine";
            optionBtnTxt8.GetComponent<Text>().text = "Cryengine";

            optionBtn3.gameObject.SetActive(false);
            optionBtn5.gameObject.SetActive(false);
            optionBtn6.gameObject.SetActive(false);
            optionBtn7.gameObject.SetActive(false);
        }
    }
}
