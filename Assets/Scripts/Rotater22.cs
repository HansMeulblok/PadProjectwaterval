using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotater22 : MonoBehaviour
{
    public float speed;
    public float min;
    public float max;

    public float z;

    public Text Pijndisplay;


    public void Start()
    {
        
        z = transform.localEulerAngles.z;
        
    
    }

    public virtual void Update()
    {
        min = -180;
        max = 0;
      
        speed = 0.2f;


        var vertical = Input.GetAxis("Mouse Y");
        z -= vertical * speed;
        z = Mathf.Clamp(z, min, max);


        if (z < max && z > min)
        {
            transform.localEulerAngles = new Vector3(0, 0, z);
            Debug.Log(transform.localEulerAngles.z);


        
        }
        if (transform.localEulerAngles.z <= 359 && transform.localEulerAngles.z >= 300)
        {
            Pijndisplay.transform.rotation = Quaternion.identity;
            Debug.Log("weinig pijn");
            Pijndisplay.text = "weinig pijn";

        }

        if (transform.localEulerAngles.z <= 299 && transform.localEulerAngles.z >= 240)
        {
            Pijndisplay.transform.rotation = Quaternion.identity;
            Debug.Log("middelmatige pijn");
            Pijndisplay.text = "middelmatige pijn";
        }

        if (transform.localEulerAngles.z <= 239 && transform.localEulerAngles.z >= 180)
        {
            Pijndisplay.transform.rotation = Quaternion.identity;
            Debug.Log("heftige pijn");
            Pijndisplay.text = "heftige pijn";
        }



    }
}
