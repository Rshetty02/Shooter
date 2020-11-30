using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onPlay : MonoBehaviour
{
    public int HighScore;

    void Start()
    {
        //HighScore = PlayerPrefs.GetInt("HighScore");

    }
    // Start is called before the first frame update
    public void onPlayPress(){
        if(GunAmmoLevelSel.SingleLauncher == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 50;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }

        if(GunAmmoLevelSel.simpleShotgun == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 50;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }
        if(GunAmmoLevelSel.DualBlastervar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 50;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }
        if(GunAmmoLevelSel.TripleBlastervar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 150;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }

        if(GunAmmoLevelSel.DualLaunchervar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 150;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }

        if(GunAmmoLevelSel.TripleLaunchervar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 200;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }

        if(GunAmmoLevelSel.ShotgunPlusvar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 150;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }

        if(GunAmmoLevelSel.UltimateShotgunvar == true){
        HighScore = PlayerPrefs.GetInt("HighScore");
        HighScore = HighScore - 200;
        PlayerPrefs.SetInt("HighScore",HighScore);
        }





        if(GunAmmoLevelSel.levelVar == 1){
            SceneManager.LoadScene("MainScene");
        }
        else if(GunAmmoLevelSel.levelVar == 2){
            HighScore = PlayerPrefs.GetInt("HighScore");
            HighScore = HighScore - 10;
            PlayerPrefs.SetInt("HighScore",HighScore);
            SceneManager.LoadScene("Level02");
        }
        else if(GunAmmoLevelSel.levelVar == 3){
            HighScore = PlayerPrefs.GetInt("HighScore");
            HighScore = HighScore - 10;
            PlayerPrefs.SetInt("HighScore",HighScore);
            SceneManager.LoadScene("Level03");
        }


    }
}
