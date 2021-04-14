using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseClassManager : MonoBehaviour
{
    public Button optionBtn;
    public Button nextSceneBtn;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        
        if (optionBtn.GetComponent<Image>().color == Color.white)
        {
            optionBtn.GetComponent<Image>().color = Color.green;
            count++;
        }
        else if (optionBtn.GetComponent<Image>().color == Color.green)
        {
            optionBtn.GetComponent<Image>().color = Color.white;
            count--;
        }
        
        if (count >= 1)
        {
            nextSceneBtn.gameObject.SetActive(true);
        }
        else
        {
            nextSceneBtn.gameObject.SetActive(false);
        }
    }
}
