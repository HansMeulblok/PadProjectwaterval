using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainMeterActive : MonoBehaviour
{
    int counter = 0;
    public GameObject Gauge1;
    public GameObject ContinueButton; 

    public void ButtonClick()
    {
        counter++;
        Debug.Log(counter);
        Update();

        if (Gauge1.activeInHierarchy)
        {
            ContinueButton.SetActive(false);

        }


    }

    void Update()
    {
        if(counter == 4)
        {
           
            Gauge1.SetActive(true);
            
        }
        if (counter == 5)
        {

            Gauge1.SetActive(false);
        }
        if (counter == 6)
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1-1");
        }

       
        if (Input.GetMouseButtonDown(0))
        {
            ContinueButton.SetActive(true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            ContinueButton.SetActive(false);
        }

    }
}
