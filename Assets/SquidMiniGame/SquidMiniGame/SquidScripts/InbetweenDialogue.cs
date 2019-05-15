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
                text.text = "De kwallen maken de rivier onveilig kan je ze verslaan?";
                break;
            case 7:
                text.text = "Er zijn meer kwallen. Help ons de kwallen te verslaan";
                break;
            case 8:
                text.text = "Ze blijven maar komen. Pas ook op voor de rotsen!";
                break;
            case 9:
                text.text = "Er zijn nog steeds veel kwallen maar het lijkt wel minder te worden";
                break;
            case 10:
                text.text = "De kwallen zijn voor nu teruggetrokken maar het gevaar is nog niet geweken";
                break;
            case 11:
                text.text = "De kwallen werken nu samen met de skeletten";
                break;
            case 12:
                text.text = "Er zijn meer kwallen en skeletten";
                break;
            case 13:
                text.text = "Onze zeewier voorraad raakt op. Raap 5 zeewier op";
                break;
            case 14:
                text.text = "de stekel vissen zijn terug met versterken. Help ons ze te verslaan";
                break;
        }
    }
}
