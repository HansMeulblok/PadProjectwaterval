using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject textBox; 

    public void ClickTheButton ()
    {
        textBox.SetActive(true);
    }

}
