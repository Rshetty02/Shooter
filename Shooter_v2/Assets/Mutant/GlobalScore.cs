using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalScore : MonoBehaviour
{
    public int CashValue;
    
    public int CurrScore;

    public int HighScore;

    public GameObject CashDisplay;

    // Start is called before the first frame update
     void Update() {

        HighScore = PlayerPrefs.GetInt("HighScore");

        CashDisplay.GetComponent<Text>().text = "Total Points :" + HighScore.ToString();
    }

    
}
