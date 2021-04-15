using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    public List<Button> btnList;
    public Button optionBtn1;
    public Button optionBtn2;
    public Button optionBtn3;
    public Button optionBtn4;
    public Button optionBtn5;
    public Button optionBtn6;
    public Button optionBtn7;
    public Button optionBtn8;
    void Start()
    {
        btnList.Add(optionBtn1);
        btnList.Add(optionBtn2);
        btnList.Add(optionBtn3);
        btnList.Add(optionBtn4);
        btnList.Add(optionBtn5);
        btnList.Add(optionBtn6);
        btnList.Add(optionBtn7);
        btnList.Add(optionBtn8);
    }
    
    public void  Reset()
    {
        foreach (Button btn in btnList)
        {
            btn.GetComponent<Image>().color = Color.white;
            btn.gameObject.SetActive(true);
        }
    }
    
}
