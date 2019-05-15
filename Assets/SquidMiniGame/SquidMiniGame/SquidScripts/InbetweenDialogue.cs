using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InbetweenDialogue : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 6:
                text.text = "kaas";
                break;
            case 7:
                text.text = "bami";
                break;
            case 8:
                text.text = "tosti";
                break;
            case 9:
                text.text = "frikandelbroodje";
                break;
            case 10:
                text.text = "spaghetti taco's";
                break;
            case 11:
                text.text = "asperges";
                break;
            case 12:
                text.text = "assburgers";
                break;
            case 13:
                text.text = "bluewaffels";
                break;
            case 14:
                text.text = "coc au vin";
                break;
        }
    }
}
