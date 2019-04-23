using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater22 : MonoBehaviour
{
    private float speed;
    private float min;
    private float max;
    

    private float z;

    private void Start()
    {
        
        z = transform.localEulerAngles.z;
    }

    private void Update()
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
        }
    }
}
