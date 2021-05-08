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
    public Text feedBackTxt;
    public Button nextSceneBtn;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    public void OnClick()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        GameObject FeedBackManager = GameObject.Find("FeedBackTracking");
        GameObject MajorManager = GameObject.Find("MajorManager");


        CountTracking countTracking = GameManager.GetComponent<CountTracking>();
        BtnManager btnManager = GameManager.GetComponent<BtnManager>();
        FeedBack feedBack = FeedBackManager.GetComponent<FeedBack>();
        FeedBack feedBackList = FeedBackManager.GetComponent<FeedBack>();
        MajorTracking majorTracking = MajorManager.GetComponent<MajorTracking>();

        GameObject Title = GameObject.Find("Title");
        FadeInOutText fadeInOutText = Title.GetComponent<FadeInOutText>();

        if (SceneManager.GetActiveScene().name == "ChooseMajor")
        {
            if (optionBtn.tag == "Major1")
            {
                majorTracking.majorChoosen = 1;
            }
            else if (optionBtn.tag == "Major2")
            {
                majorTracking.majorChoosen = 2;
            }
            else if (optionBtn.tag == "Major3")
            {
                majorTracking.majorChoosen = 3;
            }
            else if (optionBtn.tag == "Major4")
            {
                majorTracking.majorChoosen = 4;
            }
            SceneManager.LoadScene("ChooseClasses");
        }

        //================================================= MAJOR #1 ==========================================================================
        //Choose Classes Major 1
        else if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 1)
        {
           
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Full Stack Web Developers take a mix of classes that teach them applications and languages dedicated to the web. Try to choose classes that can best reflect the competencies in your field. ");
                countTracking.countA++;
            }
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

        //Choose Internship Major 1
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 1)
        {
            if (CheckAnswer() == false)
            {
                feedBack.feedBackList.Add("Front End / Full Stack engineers want to generate efforts towards internships that have you apply web based scripting languages, frameworks and possibly some UX experience.");
            }
            SceneManager.LoadScene("ChooseProject");
        }

        //Choose Project Major 1
        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 1)
        {
            if (CheckAnswer() == false)
            {
                feedBack.feedBackList.Add("Employers will consider projects as a very important aspect of the candidate they hire. It shows what you’re able to do with what you learned, and they are great examples of showing what talents you can bring to a team");
            }
            SceneManager.LoadScene("Preparation");
        }

        //Preparation Major 1
        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 1)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("It's not best to rush preparing for something so important. To ready yourself for your potential career, it helps to do as much research you can about the job, and the skills needed to perform it.");
                countTracking.countA++;
            }
            if (countTracking.count == 0)
            {
                title.text = "Some time passes as you do your applications, you eventually feel the need to brush up on what you learned. What do you do?";

                optionBtnTxt1.text = "Take on one more project to kill time";
                optionBtnTxt2.text = "Enhance one of your completed projects";
                optionBtnTxt3.text = "Take a much needed break.";
                optionBtnTxt4.text = "Wait patiently for someone to contact you on LinkedIn.";
                countTracking.count++;

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
            }

            else if (countTracking.count == 1)
            {
                title.GetComponent<Text>().text = "Now comes the part where you prepare your resume, but you have so much information that will no doubt help you stand out. What do you do?";
                optionBtnTxt1.GetComponent<Text>().text = "Customize your resume to have some information related to the job";
                optionBtnTxt2.GetComponent<Text>().text = "Have all your best achievements on there! Go hard or go home";
                optionBtn3.gameObject.SetActive(false);
                optionBtn4.gameObject.SetActive(false);
                countTracking.count++;

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
            }

            else if (countTracking.count == 2)
            {
                SceneManager.LoadScene("Interview");
            }
        }

        //Interview Major 1
        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 1)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Having excellent work habits both as an individual and as a team player also helps set you apart considerably. Talk about your strengths and weaknesses, and what you can improve on as a potential employee. ");
                countTracking.countA++;
            }

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

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Wrong";
                    optionBtn5.tag = "Correct";
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

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Wrong";
                    optionBtn5.tag = "Correct";
                    optionBtn6.tag = "Wrong";
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

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";
            }


            //Slide #4
            else if (countTracking.countS == 3)
            {
                countTracking.countS = 4;
                countTracking.count = 0;
                btnManager.Reset();
                title.GetComponent<Text>().text = "When discussing a potential salary, what would be your response?";
                optionBtnTxt1.text = "$50,000 - $65,000";
                optionBtnTxt2.text = "$65,000 - $80,000";
                optionBtnTxt3.text = "$85,000 - $100,000";
                optionBtnTxt4.text = "Ask what the budget is";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Correct";
            }

            //Slide #5
            else if (countTracking.countS == 4)
            {
                SceneManager.LoadScene("GameEnd");
            }

        }

        //================================================= MAJOR #2 ==========================================================================
        //Choose Classes Major 2
        else if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 2)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Potential Hardware Engineers are recommended to take a mix of Computer Science, Computer Engineering, and Advanced Level Math courses. ");
                countTracking.countA++;
            }
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

        //Choose Internship Major 2
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 2)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Hardware Engineer Interns perform a variety of hands-on work with their company’s servers, software, and associated technologies, among other tasks. If you wish to seek an internship in this role, its recommended to gain experience working with smaller-scale tech of the same nature, or even designing tech of your own. ");
                countTracking.countA++;
            }
            SceneManager.LoadScene("ChooseProject");
        }

        //Choose Project Major 2
        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 2)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Employers will consider projects as a very important aspect of the candidate they hire. It shows what you’re able to do with what you learned, and they are great examples of showing what talents you can bring to a team. ");
                countTracking.countA++;
            }
            SceneManager.LoadScene("Preparation");
        }

        //Preparation Major 2
        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 2)
        {
            if (countTracking.count == 0)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Its great practice to spend your time productively when it comes to professional opportunities. Brushing up on skills already taught, taking up new projects, and networking with peers are just some examples of how diligence can set you apart in the eyes of your potential employer, giving you an edge. ");
                }
                title.GetComponent<Text>().text = "You haven’t changed up your resume in a while and want to give it a little touch up, how do you want to change it?";

                optionBtnTxt1.text = "A summary of who I am as a person";
                optionBtnTxt2.text = "Small side projects that you’ve done";
                optionBtnTxt3.text = "Include long, generic objective statements";
                optionBtnTxt4.text = "My resume is fine, keep it how it is";
                countTracking.count++;

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
            }


            else if (countTracking.count == 1)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Always make sure your resume fits perfectly for any job position you apply for. If you need to  edit it in order to make sure certain information is included relating to the role, then do that.");
                }
                title.text = "You are considering getting yourself certified before you apply. What certification do you wish to gain? Choose One";
                optionBtnTxt1.text = "CompTIA A+ certification";
                optionBtnTxt2.text = "Adobe Creative Cloud Certification";
                optionBtnTxt3.text = "Oracle APEX";
                optionBtnTxt4.text = "AWS Developer Certification";
                countTracking.count++;

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
            }

            else if (countTracking.count == 2)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("When preparing to get yourself certified, take some time to research the certification you want and the employers that are looking for the skills associated. There are a variety of certification types, for a variety of purposes out there.");
                }
                SceneManager.LoadScene("Interview");
            }
        }

        //Interview Major 2
        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 2)
        {
            //Slide #1
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("A potential employee that actively engages in their professional work through many different activities are the candidates employers will favor the most. ");
                }
                countTracking.countS = 1;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                title.text = "What are some scripting languages you have used? Choose 2";
                optionBtnTxt1.text = "Perl";
                optionBtnTxt2.text = "Python";
                optionBtnTxt3.text = "PHP";
                optionBtnTxt4.text = "Javascript";
                optionBtnTxt5.text = "Pascal";
                optionBtnTxt6.text = "Cobol";
                optionBtnTxt7.text = "C++";
                optionBtnTxt8.text = "C#";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Correct";
                optionBtn5.tag = "Wrong";
                optionBtn6.tag = "Wrong";
                optionBtn7.tag = "Wrong";
                optionBtn8.tag = "Wrong";
            }

            //Slide #2
            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("One or two of the languages you have stated are not scripting languages.");
                    countTracking.countA++;
                }
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
                    countTracking.countA = 0;
                    btnManager.Reset();
                    title.text = "What is your background in engineering?";
                    optionBtnTxt1.text = "I work with Raspberry Pi devices as a hobby";
                    optionBtnTxt2.text = "I watch YouTube tutorials on how to build PCs";
                    optionBtnTxt3.text = "I studied AutoCAD way back in High School";
                    optionBtnTxt4.text = "I usually help my parents set up electronics and tech";

                    optionBtn5.gameObject.SetActive(false);
                    optionBtn6.gameObject.SetActive(false);
                    optionBtn7.gameObject.SetActive(false);
                    optionBtn8.gameObject.SetActive(false);

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Wrong";
                    optionBtn3.tag = "Correct";
                    optionBtn4.tag = "Wrong";
                }
            }

            //Slide #3
            else if (countTracking.countS == 2)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Employers will look first and foremost for hardware engineers with hands-on experience working with hardware, software, and associated tech. Having this experience offers much more interesting conversation between an employer and a candidate.");
                }
                countTracking.countS = 3;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                title.text = "When discussing a potential salary, what would be your response?";
                optionBtnTxt1.text = "$50,000 - $65,000";
                optionBtnTxt2.text = "$65,000 - $80,000";
                optionBtnTxt3.text = "$85,000 - $100,000";
                optionBtnTxt4.text = "Ask what the budget is";


                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Correct";
            }

            //Slide #4
            else if (countTracking.countS == 3)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("When preparing to seek a career, among the first things you should know is how much you should be earning, so you know what to expect from an employer offering you a position.");
                }
                countTracking.countS = 4;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                title.text = "When asked to discuss one of your projects and how you went about working on them. How would you go about doing this? Choose a combination of two answers.";
                optionBtnTxt1.text = "Talk about how it was conceived";
                optionBtnTxt2.text = "What I learned from the experience";
                optionBtnTxt3.text = "Compare it to related works of the same nature";
                optionBtnTxt4.text = "Say that it was only a way to earn your degree";
                optionBtnTxt5.text = "Explain what hardware and/ or software you used and why";

                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
                optionBtn5.tag = "Correct";
            }

            //Slide 5
            else if (countTracking.countS == 4)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Employers will always want to know more about you and your experiences to see if you’re an excellent fit with their ranks. Answers non-reflective of these will not work for them.");
                    countTracking.countA++;
                }
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
                    SceneManager.LoadScene("GameEnd");
                }
            }
        }

        else if (SceneManager.GetActiveScene().name == "GameEnd")
        {
            if (countTracking.count >= feedBack.feedBackList.Count)
            {
                countTracking.count = 0;
            }
            feedBackTxt.text = feedBack.feedBackList[countTracking.count];
            countTracking.count++;
        }
    }

    public bool CheckAnswer()
    {
        if (optionBtn.tag == "Correct")
        {
            GlobalVariables.Instance.pts++;
            Debug.Log(GlobalVariables.Instance.pts);
            return true;
        }
        else
        {
            GlobalVariables.Instance.pts--;
            Debug.Log(GlobalVariables.Instance.pts);
            return false;
        }
    }
}
