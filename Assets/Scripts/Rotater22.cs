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

    public Rigidbody2D PivotPoint_Rigidbody;

    public bool StopRotating = false; 

    public void Start()
    {
        PivotPoint_Rigidbody = GetComponent<Rigidbody2D>();
        z = transform.localEulerAngles.z;


    }


    public virtual void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            StopRotating = true;

        }
        min = -180;
            max = 0;    
            speed = 0.2f;
    
            var vertical = Input.GetAxis("Mouse Y");
            z -= vertical * speed;
            z = Mathf.Clamp(z, min, max);
     

            if ((z < max && z > min) && !StopRotating)
            {
                transform.localEulerAngles = new Vector3(0, 0, z);

           

            

            if (transform.localEulerAngles.z <= 360 && transform.localEulerAngles.z >= 300)
            {
                Pijndisplay.transform.rotation = Quaternion.identity;

                Pijndisplay.text = "weinig pijn";

            }

            if (transform.localEulerAngles.z <= 300 && transform.localEulerAngles.z >= 240)
            {
                Pijndisplay.transform.rotation = Quaternion.identity;

                Pijndisplay.text = "middelmatige pijn";
            }

            if (transform.localEulerAngles.z <= 240 && transform.localEulerAngles.z >= 180)
            {
                Pijndisplay.transform.rotation = Quaternion.identity;

                Pijndisplay.text = "heftige pijn";
            }

        }




    }
}
