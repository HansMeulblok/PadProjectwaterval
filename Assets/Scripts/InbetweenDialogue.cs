using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InbetweenDialogue : MonoBehaviour
{
    public Text Dialogue;
    string text1;
    string text2;
    string text3;
    public bool resetDialogue = true;
    void StartDialogue()
    {
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 6:
                Dialogue.text = text1;
                break;
            case 7:
                Dialogue.text = text2;
                break;
            case 8:
                Dialogue.text = text3;
                break;
            default:
                Dialogue.text = text3;
                break;
        }
    }

    void Start()
    {
        text1 = "Je bent goed opweg! Er zijn kwallen die onze rust verstoren. Jaag ze weg door op zie te schieten met inkt.";
        text2 = "Dankjewel maar het is nog niet voorbij. Er zijn meer kwallen dichtbij.";
        text3 = "Goed gedaan! Ga zo door.";
        StartDialogue();
    }
    void Update()
    {
            StartDialogue();
    }
}
