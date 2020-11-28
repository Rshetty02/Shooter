using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void onPlayPress(){

        if(GunAmmoLevelSel.levelVar == 1){
            SceneManager.LoadScene("MainScene");
        }
        else if(GunAmmoLevelSel.levelVar == 2){
            SceneManager.LoadScene("Level02");
        }
        else if(GunAmmoLevelSel.levelVar == 3){
            SceneManager.LoadScene("Level03");
        }


    }
}
