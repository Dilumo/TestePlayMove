using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseController : MonoBehaviour {

    private Vector3 lastPos;
    private Vector3 delta;
    private float speed;
    private float distance;

    // Update is called once per frame
    void Update ()
    {
        MosusePosition();
    }

    private void MosusePosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            delta = Input.mousePosition - lastPos;

            distance = delta.magnitude;

            speed = distance / Time.deltaTime;

            if (distance > 20f && speed > 1500f)
            {
                    // Fazer algo relacionado a direção
            }

            // End do stuff

            lastPos = Input.mousePosition;
        }
    }
}
