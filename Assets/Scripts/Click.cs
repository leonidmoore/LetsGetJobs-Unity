using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Click : MonoBehaviour
{
    public Button optionBtn;
    public Button nextSceneBtn;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneBtn.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        CountTracking countTracking = GameManager.GetComponent<CountTracking>();

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
                nextSceneBtn.gameObject.SetActive(true);
            }
            else
            {
                nextSceneBtn.gameObject.SetActive(false);
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
