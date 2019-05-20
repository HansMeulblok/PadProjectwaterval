using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    float scrollSpeed = 0.5f;
    Vector3 startPos;
    Vector3 minusPos;
   // RectTransform rt;


    void Start()
    {
        minusPos = new Vector3(0, 19.2f * 3f, 0);
        startPos = transform.position;
     //   rt = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //float newPos = Mathf.Repeat(Time.time * scrollSpeed, 35);
        transform.position += new Vector3(0, -0.01f, 0);
        switch (this.tag)
        {
            case "JungleBackground": 
                if (transform.position.y < -51.250401)
                    transform.position += new Vector3(0, 51.250401f * 3f, 0);
                break;
            case "DefaultBackground":
                if (transform.position.y < -19.2)
                    transform.position += new Vector3(0, 19.2f * 3f, 0);
                break;
            case "IndustrieBackground":
                if (transform.position.y < -51.250401)
                    transform.position += new Vector3(0, 51.250401f * 3f, 0);
                break;
            case "RuinBackground":
                if (transform.position.y < -51.250401)
                    transform.position += new Vector3(0, 51.250401f * 3f, 0);
                break;
        }

        

    }
}
