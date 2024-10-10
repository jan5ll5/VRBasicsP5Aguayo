using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugRotation : MonoBehaviour
{
    public float speed = 0f;
    public bool ForwardX = false;
    public bool ForwardY = false;
    public bool ForwardZ = false;

   
    public bool ReverseX = false;
    public bool ReverseY = false;
    public bool ReverseZ = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ForwardX == true)
        {
            transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if (ForwardY == true)
        {
            transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
        }
        if (ForwardZ == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * speed, Space.Self);
        }
        //Reverse Direction
        if (ReverseX == true)
        {
            transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if (ReverseY == true)
        {
            transform.Rotate(0, -Time.deltaTime * speed, 0, Space.Self);
        }
        if (ReverseZ == true)
        {
            transform.Rotate(0, 0, -Time.deltaTime * speed, Space.Self);
        }
    }
}
