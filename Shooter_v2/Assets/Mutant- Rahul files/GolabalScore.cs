﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolabalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue = 0;
    public int internalScore;

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
        
    }
}
