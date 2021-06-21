using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static bool created = false;
    private void Awake()
    {
       
        if (created == false)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Debug.Log("Desttry");
            Destroy(this.gameObject);
        }
    }
}
