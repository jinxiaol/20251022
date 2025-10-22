using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x -
            this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text =
            "Distance:" + length.ToString("F2") + "m";
    }
}
