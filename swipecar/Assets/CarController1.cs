using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarController1 : MonoBehaviour
{
    float speed = 0;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.2f;
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}

