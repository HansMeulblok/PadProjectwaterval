﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainMeterActive : MonoBehaviour
{
    int counter = 0;
    public GameObject Gauge1;
    public GameObject textBox;


    public void ButtonClick()
    {
        counter++;
        Debug.Log(counter);
        Update(); 
    }

    void Update()
    {
        if(counter == 4)
        {
           
            Gauge1.SetActive(true);
            
       
        }
        if (counter == 5)
        {
            textBox.SetActive(false);
            Gauge1.SetActive(false);
        }
        if (counter == 6)
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1-1");
        }


    }
}
