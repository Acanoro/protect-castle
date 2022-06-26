using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtons : MonoBehaviour
{
    public int count = 0;

    public GameObject button1, button2;
    
    public void Change()
    {
        count++;
        if (count==2)
        {
            button1.SetActive(false);
            button2.SetActive(true);
        }
        
    }
   
}
