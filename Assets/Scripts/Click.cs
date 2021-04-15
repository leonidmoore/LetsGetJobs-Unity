using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Click : MonoBehaviour
{
    public Button optionBtn;

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
    public Button nextSceneBtn;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("NextScene") != null)
        {
            nextSceneBtn.gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        
        CountTracking countTracking = GameManager.GetComponent<CountTracking>();
        BtnManager btnManager = GameManager.GetComponent<BtnManager>();


        if (SceneManager.GetActiveScene().name == "ChooseClasses")
        {
            if (countTracking.count <= 4)
            {
                if (optionBtn.GetComponent<Image>().color == Color.white && countTracking.count != 4)
                {
                    optionBtn.GetComponent<Image>().color = Color.green;
                    countTracking.count++;
                }
                else if (optionBtn.GetComponent<Image>().color == Color.green)
                {
                    optionBtn.GetComponent<Image>().color = Color.white;
                    countTracking.count--;
                }
            }

            if (countTracking.count == 4)
            {
                SceneManager.LoadScene("ChooseInternship");
            }
        }

        if (SceneManager.GetActiveScene().name == "Preparation")
        {
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

            else if (countTracking.count == 2)
            {
                SceneManager.LoadScene("Interview");
            }
        }

        //Interview Scene
        if (SceneManager.GetActiveScene().name == "Interview")
        {
            //Slide #1
            if (countTracking.countS == 0)
            {
                if (countTracking.count < 2)
                {
                    if (optionBtn.GetComponent<Image>().color == Color.white)
                    {
                        optionBtn.GetComponent<Image>().color = Color.green;
                        countTracking.count++;
                    }
                    else if (optionBtn.GetComponent<Image>().color == Color.green)
                    {
                        optionBtn.GetComponent<Image>().color = Color.white;
                        countTracking.count--;
                    }
                }
                else
                {
                    countTracking.countS = 1;
                    countTracking.count = 0;
                    btnManager.Reset();
                    title.GetComponent<Text>().text = "When asked to discuss one of your projects and how you went about working on them. How would you go about doing this? Choose a combination of two answers.";
                    optionBtnTxt1.GetComponent<Text>().text = "Talk about how it was conceived";
                    optionBtnTxt2.GetComponent<Text>().text = "What I learned from the experience";
                    optionBtnTxt3.GetComponent<Text>().text = "Compare it to related works of the same nature";
                    optionBtnTxt4.GetComponent<Text>().text = "Say that it was only a way to earn your degree";
                    optionBtnTxt5.GetComponent<Text>().text = "Explain what stack you used and why";

                    optionBtn6.gameObject.SetActive(false);
                    optionBtn7.gameObject.SetActive(false);
                    optionBtn8.gameObject.SetActive(false);
                }

            }

            //Slide #2
            else if (countTracking.countS == 1)
            {
                if (countTracking.count < 1)
                {
                    if (optionBtn.GetComponent<Image>().color == Color.white)
                    {
                        optionBtn.GetComponent<Image>().color = Color.green;
                        countTracking.count++;
                    }
                    else if (optionBtn.GetComponent<Image>().color == Color.green)
                    {
                        optionBtn.GetComponent<Image>().color = Color.white;
                        countTracking.count--;
                    }
                }
                else
                {
                    countTracking.countS = 2;
                    countTracking.count = 0;
                    btnManager.Reset();
                    title.GetComponent<Text>().text = "When asked what your greatest weakness is, what do you say?";
                    optionBtnTxt1.GetComponent<Text>().text = "Attention to detail can often be a detriment";
                    optionBtnTxt2.GetComponent<Text>().text = "I would try to take tasks upon myself when I’m on a team";
                    optionBtnTxt3.GetComponent<Text>().text = "I work too hard, I care too much. ";
                    optionBtnTxt4.GetComponent<Text>().text = "I can't think of any at the moment";
                    optionBtnTxt5.GetComponent<Text>().text = "I take it to heart when I can’t get things done";
                    optionBtnTxt6.GetComponent<Text>().text = "I tend to go my own way sometimes?";

                    optionBtn7.gameObject.SetActive(false);
                    optionBtn8.gameObject.SetActive(false);
                }

            }


            //Slide #3
            else if (countTracking.countS == 2)
            {
                countTracking.countS = 3;
                countTracking.count = 0;
                btnManager.Reset();
                title.GetComponent<Text>().text = "When asked, “Why are you interested in this job,” what is your best response?";
                optionBtnTxt1.GetComponent<Text>().text = "It’s always been a dream of mine to work at this company";
                optionBtnTxt2.GetComponent<Text>().text = "Figured it was cool to apply ";
                optionBtnTxt3.GetComponent<Text>().text = "There’s a lot i can bring to the company";
                optionBtnTxt4.GetComponent<Text>().text = "It’s one of the few positions where I meet all the requirements";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }


            //Slide #4
            else if (countTracking.countS == 3)
            {
                countTracking.countS = 4;
                countTracking.count = 0;
                btnManager.Reset();
                title.GetComponent<Text>().text = "When discussing a potential salary, what would be your response?";
                optionBtnTxt1.GetComponent<Text>().text = "$50,000 - $65,000";
                optionBtnTxt2.GetComponent<Text>().text = "$65,000 - $80,000";
                optionBtnTxt3.GetComponent<Text>().text = "$85,000 - $100,000";

                optionBtn4.gameObject.SetActive(false);
                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #5
            else if (countTracking.countS == 4)
            {
                SceneManager.LoadScene("GameEnd");
            }

        }

        /*
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" || SceneManager.GetActiveScene().name == "ChooseProject")
        {
            if (countTracking.count <= 1)
            {
                if (optionBtn.GetComponent<Image>().color == Color.white && countTracking.count != 1)
                {
                    optionBtn.GetComponent<Image>().color = Color.green;
                    countTracking.count++;
                }
                else if (optionBtn.GetComponent<Image>().color == Color.green)
                {
                    optionBtn.GetComponent<Image>().color = Color.white;
                    countTracking.count--;
                }
            }

            if (countTracking.count == 1)
            {
                nextSceneBtn.gameObject.SetActive(true);
            }
            else
            {
                nextSceneBtn.gameObject.SetActive(false);
            }
        }
        */
    }
}
