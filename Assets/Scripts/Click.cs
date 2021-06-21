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
    public Text someText;

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
                fadeInOutText.FadeIn();
                title.text = "Some time passes as you do your applications, you eventually feel the need to brush up on what you learned. What do you do? (pick 1)";

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
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "Now comes the part where you prepare your resume, but you have so much information that will no doubt help you stand out. What do you do? (pick 1)";
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
                    fadeInOutText.FadeIn();
                    title.GetComponent<Text>().text = "What is your favorite scripting language for web development and why? (pick 1)";
                    optionBtnTxt1.GetComponent<Text>().text = "JavaScript, because it gives me the ability to create unique and dynamic interfaces";
                    optionBtnTxt2.GetComponent<Text>().text = "Python, because I like the ease of debugging with Python";
                    optionBtnTxt3.GetComponent<Text>().text = "JavaScript, because of its popularity";
                    optionBtnTxt4.GetComponent<Text>().text = "Python, because I love game development with Pygame";

                    optionBtn5.gameObject.SetActive(false);
                    optionBtn6.gameObject.SetActive(false);
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
            
            //Slide 2
            else if (countTracking.countS == 1)
            {
                countTracking.countS = 2;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "Are you ready to learn new technologies? (pick 1)";
                optionBtnTxt1.GetComponent<Text>().text = "Yes, I always look forward to adopting any new language/framework";
                optionBtnTxt2.GetComponent<Text>().text = "No, I find new changes to be troublesome and slows me down";
                optionBtnTxt3.GetComponent<Text>().text = "Yes, I don’t enjoy working with old code";
                optionBtnTxt4.GetComponent<Text>().text = "Yes, but I am also quite adept at working with legacy code";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Correct";
            }

            //Slide 3
            else if (countTracking.countS == 2)
            {
                countTracking.countS = 3;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "What does HTML Stand For? (pick 1)";
                optionBtnTxt1.GetComponent<Text>().text = "Hypertext Meta Language";
                optionBtnTxt2.GetComponent<Text>().text = "Hypertext Markup Language";
                optionBtnTxt3.GetComponent<Text>().text = "Hit The Mother Lode";
                optionBtnTxt4.GetComponent<Text>().text = "Hyperactive Text Machine Language";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
            }

            //Slide 4
            else if (countTracking.countS == 3)
            {
                countTracking.countS = 4;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "Why is W3C (World Wide Web Consortium) important for Web developers? (pick 1)";
                optionBtnTxt1.GetComponent<Text>().text = "It optimizes the experience of browsing the web for all users";
                optionBtnTxt2.GetComponent<Text>().text = "It ensures that web content is accessible in all browsers to reach all audiences";
                optionBtnTxt3.GetComponent<Text>().text = "They believe the web should not be free to its users.";
                optionBtnTxt4.GetComponent<Text>().text = "I don't know what the W3C is, but I am willing to learn more. ";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Correct";
            }


            //Slide #5
            else if (countTracking.countS == 4)
            {
                countTracking.countS = 5;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "When asked to discuss one of your projects and how you went about working on them. How would you go about doing this? (pick 2)";
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

            //Slide #6
            else if (countTracking.countS == 5)
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
                    countTracking.countS = 6;
                    countTracking.count = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.GetComponent<Text>().text = "When asked what your greatest weakness is, what do you say? (pick 1)";
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


            //Slide #7
            else if (countTracking.countS == 6)
            {
                countTracking.countS = 7;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "When asked, “Why are you interested in this job,” what is your best response? (pick 1)";
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


            //Slide #8
            else if (countTracking.countS == 7)
            {
                countTracking.countS = 8;
                countTracking.count = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "When discussing a potential salary, what would be your response? (pick 1)";
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
            else if (countTracking.countS == 8)
            {
                SceneManager.LoadScene("GameEnd");
            }

        }

        //================================================= MAJOR 2 ==========================================================================
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
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Its great practice to spend your time productively when it comes to professional opportunities. Brushing up on skills already taught, taking up new projects, and networking with peers are just some examples of how diligence can set you apart in the eyes of your potential employer, giving you an edge. ");
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
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.GetComponent<Text>().text = "You haven’t changed up your resume in a while and want to give it a little touch up, how do you want to change it? (pick 2)";

                    optionBtnTxt1.text = "A summary of who I am as a person";
                    optionBtnTxt2.text = "Small side projects that you’ve done";
                    optionBtnTxt3.text = "Include long, generic objective statements";
                    optionBtnTxt4.text = "List all the programming languages that you know";
                    countTracking.countS++;

                    optionBtn1.tag = "Wrong";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Correct";
                }
            }


            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Always make sure your resume fits perfectly for any job position you apply for. If you need to  edit it in order to make sure certain information is included relating to the role, then do that.");
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
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();

                    title.text = "You are considering getting yourself certified before you apply. What certification do you wish to gain? (pick 1)";
                    optionBtnTxt1.text = "CompTIA A+ certification";
                    optionBtnTxt2.text = "Adobe Creative Cloud Certification";
                    optionBtnTxt3.text = "Oracle APEX";
                    optionBtnTxt4.text = "AWS Developer Certification";
                    countTracking.countS++;

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Wrong";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Wrong";
                }
            }

            else if (countTracking.countS == 2)
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
                fadeInOutText.FadeIn();
                title.text = "What are some scripting languages you have used? (pick 2)";
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
                    fadeInOutText.FadeIn();
                    title.text = "What is your background in engineering? (pick 1)";
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
                fadeInOutText.FadeIn();
                title.text = "When discussing a potential salary, what would be your response? (pick 1)";
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
                fadeInOutText.FadeIn();
                title.text = "When asked to discuss one of your projects and how you went about working on them. How would you go about doing this? (pick 2)";
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

        //================================================= MAJOR #3 ==========================================================================
        //Choose Classes Major 3
        else if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 3)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Aspiring Database Engineers are recommended to take a mix of Computer Science, Information Technology, and Advanced Level Logic courses.");
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

        //Choose Internship Major 3
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 3)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Those interested in a database engineering internship should become familiar with designing and managing databases for websites, and web-focused back end frameworks that aid in their design, among many other things.");
                countTracking.countA++;
            }
            SceneManager.LoadScene("ChooseProject");
        }

        //Choose Project Major 3
        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 3)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Potential Final Projects for Database Engineers should involve some use of popular industry reliant database technologies");
                countTracking.countA++;
            }
            SceneManager.LoadScene("Preparation");
        }

        //Preparation Major 3
        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 3)
        {
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Employers will consider projects as a very important aspect of the candidate they hire. It shows what you’re able to do with what you learned, and they are great examples of showing what talents you can bring to a team");
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
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.GetComponent<Text>().text = "You’ve applied for a job and you got an interview scheduled in a few weeks, what should you do before then? (pick 2)";

                    optionBtnTxt1.text = "Brush up on your knowledge";
                    optionBtnTxt2.text = "Start a massive project to show to the interviewer";
                    optionBtnTxt3.text = "Study potential interview questions";
                    optionBtnTxt4.text = "Brag about it on social media";
                    countTracking.countS++;

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Wrong";
                    optionBtn3.tag = "Correct";
                    optionBtn4.tag = "Wrong";
                }
            }


            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("It's not best to rush preparing for something so important. To prepare yourself for your potential career, it helps to do as much research you can about the job, and the skills needed to perform it.");
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
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.text = "You are considering getting yourself certified before you apply. What certification do you wish to gain? (pick 1)";
                    optionBtnTxt1.text = "Google Cloud Certified Professional Data Engineer";
                    optionBtnTxt2.text = "AWS Certified Big Data Engineer";
                    optionBtnTxt3.text = "Autodesk Certified Professional - AutoCAD";
                    optionBtnTxt4.text = "No Certifications - I have enough experience";
                    countTracking.countS++;

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Wrong";
                }
            }

            else if (countTracking.countS == 2)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Unlike certain other positions, a certification/licensure on any resume for potential Database Engineers is essential, so it’s highly recommended you earn one.");
                }
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "You just realized that there is a small bug within the project that you want to share with the interviewer and what would you do? (pick 1)";
                optionBtnTxt1.text = "Try to debug";
                optionBtnTxt2.text = "Ask your peers for help";
                optionBtnTxt3.text = "Leave it as it was, it didn’t become problem before and should not become a problem now";
                optionBtnTxt4.text = "Attempt to hide the bug";
                countTracking.countS++;

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Wrong";
            }

            else if (countTracking.countS == 3)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("If you couldn't debug your project before the big day, definitely let your interviewer know. They will appreciate and note your transparency.");
                }
                SceneManager.LoadScene("Interview");
            }
        }

        //Interview Major 3
        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 3)
        {
            //Slide #1
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Learning SQL, what it means, and its many functions are a few of the most important topics of databases. ");
                }
                countTracking.countS = 1;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "What type of databases do you prefer to work with and why? (pick 1)";
                optionBtnTxt1.text = "SQL because it provides a highly organized and structured approach to store and manage.";
                optionBtnTxt2.text = "SQL because No-SQL is more difficult to deal with and lack of tools that support it.";
                optionBtnTxt3.text = "No-SQL because it allows you to store and organize information in a loose manner. There is no limitation on types of data that can be stored.";
                optionBtnTxt4.text = "NO-SQL because SQL is too strict and not having enough flexibility to work with.";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #2
            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("You work with the right types of databases for the wrong reasons.");
                }

                countTracking.countS = 2;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "How would you handle a situation where you encounter a data loss during a database migration which you don’t know how to solve? (pick 1)";
                optionBtnTxt1.text = "Inform your manager and ask for help";
                optionBtnTxt2.text = "Search online for a possible solution";
                optionBtnTxt3.text = "Ask your co-workers for help";
                optionBtnTxt4.text = "Just leave it for the next person to handle";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #3
            else if (countTracking.countS == 2)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Always use your network when it comes to solving problems. 2+ heads are always better than one, and you only know as much as the person next to you.");
                }
                countTracking.countS = 3;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "What are some of the ways that help troubleshoot database problems? (pick 2)";
                optionBtnTxt1.text = "Check regularly to see if anyone is reporting performance issues or other concerns.";
                optionBtnTxt2.text = "Test it on several environment and machines to make sure everything work the same";
                optionBtnTxt3.text = "Review the SQL or NO-SQL error log";
                optionBtnTxt4.text = "Check it once several weeks";
                optionBtnTxt5.text = "Use automated tools to check for you instead of manual works";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";
                optionBtn5.tag = "Wrong";

                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #4
            else if (countTracking.countS == 3)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("The best Database engineers will leave no stone unturned when it comes to running tests and ensuring things run smoothly. They act immediately even when some may potentially be an issue. ");
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
                    countTracking.countS = 4;
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.text = "When discussing a potential salary, what would be your response? (pick 1)";
                    optionBtnTxt1.text = "$40,000 - $60,000";
                    optionBtnTxt2.text = "$75,000 - $90,000";
                    optionBtnTxt3.text = "$100,000 - $110,000";
                    optionBtnTxt4.text = "Ask what the budget is";

                    optionBtn1.tag = "Wrong";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Correct";

                    optionBtn5.gameObject.SetActive(false);
                    optionBtn6.gameObject.SetActive(false);
                    optionBtn7.gameObject.SetActive(false);
                    optionBtn8.gameObject.SetActive(false);
                }
            }

            //Slide 5
            else if (countTracking.countS == 4)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("When preparing to seek a career, among the first things you should know is how much you should be earning, so you know what to expect from an employer offering you a position.");
                }
                SceneManager.LoadScene("GameEnd");
            }
        }

        //================================================= MAJOR #4 ==========================================================================
        //Choose Classes Major 4
        else if (SceneManager.GetActiveScene().name == "ChooseClasses" && majorTracking.majorChoosen == 4)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("It's recommended that aspiring Game Developers take a medley of courses  teaching programming, math/logic, and some class which teaches concepts and skills applicable to game development, of which there are many.");
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

        //Choose Internship Major 4
        else if (SceneManager.GetActiveScene().name == "ChooseInternship" && majorTracking.majorChoosen == 4)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("Those Interested in an Internship regarding Video Game Development should be prepared to know more about the life cycle of Game Production, and showing where your skills fit into it, from concept, to design, to production, to testing, and eventually release.");
                countTracking.countA++;
            }
            SceneManager.LoadScene("ChooseProject");
        }

        //Choose Project Major 4
        else if (SceneManager.GetActiveScene().name == "ChooseProject" && majorTracking.majorChoosen == 4)
        {
            if (CheckAnswer() == false && countTracking.countA == 0)
            {
                feedBack.feedBackList.Add("A great final project for a game developer should involve the use of current and/or trending techniques and tools dedicated to Game Design, such as Game Engines, Modeling Softwares and the like. Prove that you have the competencies to stand amongst your peers because this field is more competitive than the others!");
                countTracking.countA++;
            }
            SceneManager.LoadScene("Preparation");
        }

        //Preparation Major 4
        else if (SceneManager.GetActiveScene().name == "Preparation" && majorTracking.majorChoosen == 4)
        {
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Developers meetups are a great way to meet professionals and like-minded individuals from the industry. These meetups are also a hub for collaboration, learning, and socializing, you can establish long lasting friendships that may be beneficial to you along your career");
                }
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.GetComponent<Text>().text = "You noticed that there are many open positions for a company you’re interested in, which of the following should you apply to? (pick 2)";

                optionBtnTxt1.text = "Associate gameplay engineer";
                optionBtnTxt2.text = "Head of design";
                optionBtnTxt3.text = "AI designer";
                optionBtnTxt4.text = "Senior gameplay designer";
                countTracking.countS++;

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";
            }


            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Head of Design, and Senior Gameplay Designer are senior roles which you do not have the experience for as a fresh graduate, and Systems Administrator is not a game design job");
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
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.text = "Some time has passed after you applied for your position, you’ve received notice that your interview will be within the next few weeks, what should you do to prepare for the interview? (pick 2)";
                    optionBtnTxt1.text = "Study up on related topics";
                    optionBtnTxt2.text = "Spend a bit of time to play one of the company’s released games";
                    optionBtnTxt3.text = "Spend the time playing a bunch of different video games";
                    optionBtnTxt4.text = "Prepare a personal blog website to show to the interviewer";
                    countTracking.countS++;

                    optionBtn1.tag = "Correct";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Wrong";
                }
            }

            else if (countTracking.countS == 2)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("Playing one of the company’s games and being able to demonstrate it during the interview shows that you are passionate and truly care about the company. Doing so may make you stand out amongst all the candidates.");
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
                    SceneManager.LoadScene("Interview");
                }
                
            }
        }

        //Interview Major 4
        else if (SceneManager.GetActiveScene().name == "Interview" && majorTracking.majorChoosen == 4)
        {
            //Slide #1
            if (countTracking.countS == 0)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Unreal, Godot, and Cryengine are popular game frameworks that have been popularized for some time now. Although they specialize in computer graphics, Nvidia is not known for making Game Engines.");
                }
                countTracking.countS = 1;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "When met with general playerbase dissatisfaction of your game, as a game developer, what should you do? (pick 1)";
                optionBtnTxt1.text = "Increase communication with the players";
                optionBtnTxt2.text = "The developers are always right, ignore the players and continue to follow the roadmap.";
                optionBtnTxt3.text = "Attempt to fix the issue that causes the dissatisfaction";
                optionBtnTxt4.text = "Release a statement with an excuse";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #2
            else if (countTracking.countS == 1)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("When there is dissatisfaction within the playbase, the most important thing you can do as a developer is communication and transparency, ignoring the player’s concerns will inevitably dwindle the player base as the players do not feel that their voices are being heard. This will not only harm your current game, but your future game releases may suffer as well due to the bad reputation.");
                }

                countTracking.countS = 2;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "What made you pursue game design? (pick 1)";
                optionBtnTxt1.text = "I can see the potential for immense growth within the industry";
                optionBtnTxt2.text = "I believe that game design is a job that pays well.";
                optionBtnTxt3.text = "Game design was a hobby of mine that I wanted to turn into a career";
                optionBtnTxt4.text = "I think that game design is an easy job";

                optionBtn1.tag = "Correct";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";
                optionBtn4.tag = "Wrong";

                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #3
            else if (countTracking.countS == 2)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("Employers will much rather have someone passionate about video games to some extent than someone that simply isn't, And there are thousands of passionate individuals simply trying to make it in.");
                }
                countTracking.countS = 3;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = " How much time do you dedicate to working on games (pick 1)";
                optionBtnTxt1.text = "Not a lot of time, I rather play them most of the time";
                optionBtnTxt2.text = "I dedicate some time every month to special projects";
                optionBtnTxt3.text = "Almost 40 hours a week, its a side hustle.";
 

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Wrong";
                optionBtn3.tag = "Correct";

                optionBtn4.gameObject.SetActive(false);
                optionBtn5.gameObject.SetActive(false);
                optionBtn6.gameObject.SetActive(false);
                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #4
            else if (countTracking.countS == 3)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("The average game takes a few years to be developed and released, so employers want to see how much time you not only  dedicate to personal projects, but how much you can dedicate to their projects.");
                }
                countTracking.countS = 4;
                countTracking.count = 0;
                countTracking.countA = 0;
                btnManager.Reset();
                fadeInOutText.FadeIn();
                title.text = "When beginning to design a game, what is an important aspect that a game developer should keep in mind? (pick 2)";
                optionBtnTxt1.text = "How the game should be advertised when released";
                optionBtnTxt2.text = "The way the playable area is designed";
                optionBtnTxt3.text = "Implementing micro-transaction elements to earn money";
                optionBtnTxt4.text = "Provide conflict within the game in the form of competition, challenge, etc";
                optionBtnTxt5.text = "Features at the end of the roadmap";
                optionBtnTxt6.text = "Communication with your co-workers";

                optionBtn1.tag = "Wrong";
                optionBtn2.tag = "Correct";
                optionBtn3.tag = "Wrong";
                optionBtn4.tag = "Correct";
                optionBtn5.tag = "Wrong";
                optionBtn6.tag = "Correct";

                optionBtn7.gameObject.SetActive(false);
                optionBtn8.gameObject.SetActive(false);
            }

            //Slide #5
            else if (countTracking.countS == 4)
            {
                if (CheckAnswer() == false && countTracking.countA == 0)
                {
                    feedBack.feedBackList.Add("The design of the playable area and conflicts within the game are some of the most important aspects of game design. They are the main ways the players interact with your game. How you design these may make or break when it comes to a success of a game in certain situations.");
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
                    countTracking.countS = 5;
                    countTracking.count = 0;
                    countTracking.countA = 0;
                    btnManager.Reset();
                    fadeInOutText.FadeIn();
                    title.text = "When discussing a potential salary, what would be your response? (pick 1)";
                    optionBtnTxt1.text = "$40,000 - $60,000";
                    optionBtnTxt2.text = "$75,000 - $90,000";
                    optionBtnTxt3.text = "$100,000 - $110,000";
                    optionBtnTxt4.text = "Ask what the budget is";

                    optionBtn1.tag = "Wrong";
                    optionBtn2.tag = "Correct";
                    optionBtn3.tag = "Wrong";
                    optionBtn4.tag = "Correct";

                    optionBtn5.gameObject.SetActive(false);
                    optionBtn6.gameObject.SetActive(false);
                    optionBtn7.gameObject.SetActive(false);
                    optionBtn8.gameObject.SetActive(false);
                }
 
            }

            //Slide 6
            else if (countTracking.countS == 5)
            {
                if (CheckAnswer() == false)
                {
                    feedBack.feedBackList.Add("When preparing to seek a career, among the first things you should know is how much you should be earning, so you know what to expect from an employer offering you a position.");
                }
                SceneManager.LoadScene("GameEnd");
            }
        }


        //----------------------------------------------------------------------------------------

        else if (SceneManager.GetActiveScene().name == "GameEnd")
        {
            GameObject FeedBack = GameObject.Find("FeedBack");
            FadeInOutText fadeInText = FeedBack.GetComponent<FadeInOutText>();

            if (feedBack.feedBackList.Count == 0)
            {
                fadeInText.FadeIn();
                feedBackTxt.text = "There is no advice for you because you were perfect!";
            }
            else
            {
                if (countTracking.count >= feedBack.feedBackList.Count)
                {
                    countTracking.count = 0;
                    optionBtn.GetComponent<Image>().color = Color.red;
                }
                fadeInText.FadeIn();
                feedBackTxt.text = feedBack.feedBackList[countTracking.count];
                countTracking.count++;
            }
            
        }
    }

    public void IntroClick()
    {
        GameObject IntroText = GameObject.Find("IntroText");
        FadeInOutText fadeInOutText = IntroText.GetComponent<FadeInOutText>();

        GameObject GameManager = GameObject.Find("GameManager");
        IntroCount introCount = GameManager.GetComponent<IntroCount>();
        if (introCount.introCount == 0)
        {
            introCount.introCount++;
            fadeInOutText.FadeIn();
            someText.text = "In this game, you are given freedom to define your path of success. Choose a career you wish to aim for and answer the questions that best reflect what you would do in a given scenario. \n\n See where the results take you, and if you can make it to the end and earn a position in your career, you win! Otherwise, the game will provide helpful feedback in making better choices to change your outcome.";
        }
        else if (introCount.introCount == 1)
        {
            introCount.introCount++;
            fadeInOutText.FadeIn();
            someText.text = "The game is designed to educate players on how CS students can go about earning the careers they want. By cultivating professional habits, learning desired skills, and performing great interviews, your future will look bright. We hope this game at the very least will serve as  a solid foundation for you.\n\n Are you ready? Then Let's Begin";
            optionBtnTxt1.text = "START";
        }
        else
        {
            SceneManager.LoadScene("ChooseMajor");
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
        return false;
        /*
        else
        {
            GlobalVariables.Instance.pts--;
            Debug.Log(GlobalVariables.Instance.pts);
            return false;
        }
        */
    }
}
