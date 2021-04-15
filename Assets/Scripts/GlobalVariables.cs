using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    public static GlobalVariables Instance;

    public int pts;


    public void Awake()
    {
        Instance = this;
    }
}
