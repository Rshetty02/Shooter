using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{

    public GameObject goldIngots;
    public AudioSource collectSound;

    public int score;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {

        if(other.tag == "Player"){
        collectSound.Play();
        GolabalScore.scoreValue += 1;
        //score = PlayerPrefs.GetInt("HighScore") + GolabalScore.scoreValue;
        //PlayerPrefs.SetInt("HighScore",score);


        goldIngots.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;
        }



    }
}
