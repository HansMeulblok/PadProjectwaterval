using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotater22 : MonoBehaviour
{
    public float speed; // Speed of the painmeter
    public float min;   // minimum limiet van pijnmeter
    public float max;   // maximum limiet van pijnmeter 

    public float RotationZ;  // pijnmeter rotatie

    public Text Pijndisplay; // de hoeveelheid pijn die gegeven is

    public Rigidbody2D PivotPoint_Rigidbody;  // het pijnt meter object

    public bool StopRotating = false; 

    public void Start()
    {
        PivotPoint_Rigidbody = GetComponent<Rigidbody2D>();
        RotationZ = transform.localEulerAngles.z;     // laat rotationz om de z as draaien
        min = -180;
        max = 0;
        speed = 6f;
    }


    public virtual void Update()
    {

        if (Input.GetMouseButtonDown(0))   // dit zorgt ervoor dat de stoprotating op true wordt gezet als de pijnmeter bezig is.
        {

            StopRotating = true;

        }

        if (Input.GetMouseButtonDown(1))
        {

            StopRotating = false;

        }

            var vertical = Input.GetAxis("Mouse Y");   
            RotationZ -= vertical * speed;
            RotationZ = Mathf.Clamp(RotationZ, min, max);  // dit zorgt ervoor dat als de muis verticaal beweegt de pijnmeter omhoog of omlaag
     

            if ((RotationZ < max && RotationZ > min) && !StopRotating)           // dit checkt of de pijnmeter tussen de max en de min zit en of hij is gestopt met
            {
                transform.localEulerAngles = new Vector3(0, 0, RotationZ);     // zet de pijnmeter op het minimum

            if (transform.localEulerAngles.z <= 360 && transform.localEulerAngles.z >= 300)  // geeft aan tussen 360 en 300 graden dat er "weinig pijn" 
            {
                Pijndisplay.transform.rotation = Quaternion.identity;                       // zorgt ervoor dat de pijnmeter niet mee roteert

                Pijndisplay.text = "weinig pijn";

            }

            if (transform.localEulerAngles.z <= 300 && transform.localEulerAngles.z >= 240)  // geeft aan tussen 300 en 240 graden dat er "middelmatige pijn" 
            {
                Pijndisplay.transform.rotation = Quaternion.identity;

                Pijndisplay.text = "middelmatige pijn";
            }

            if (transform.localEulerAngles.z <= 240 && transform.localEulerAngles.z >= 180)   // geeft aan tussen 240 en 180 graden dat er "heftige pijn" 
            {
                Pijndisplay.transform.rotation = Quaternion.identity;

                Pijndisplay.text = "heftige pijn";
            }

        }




    }
}
