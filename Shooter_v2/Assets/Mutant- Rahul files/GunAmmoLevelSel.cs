using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmoLevelSel : MonoBehaviour
{
    public static int gunVar =1;

    public static bool DualBlastervar = false;

    public static bool TripleBlastervar = false;

    public static bool SingleLauncher = false;
    public static bool DualLaunchervar = false;
    public static bool TripleLaunchervar = false;
    public static bool simpleShotgun = false;
    public static bool ShotgunPlusvar = false;
    public static bool UltimateShotgunvar = false;

    public int HighScore;


    public static int levelVar =1;

    public static int GunMode = 1;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GunSelectionBlaster(){
    //gunVar = 1;

    }

    public void GunSelectionLauncher(){
        //gunVar = 2;
        SingleLauncher = true;
        //HighScore = HighScore - 50;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void GunSelectionShotGun(){
        //gunVar = 3;
        simpleShotgun= true;
        //HighScore = HighScore - 50;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void FirstLevel(){
        levelVar =1;
    }

    public void SecondLevel(){
        levelVar = 2;
        HighScore = HighScore - 10;
        PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void ThirdLevel(){
        levelVar = 3;
        HighScore = HighScore - 10;
        PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void DualBlaster(){
        gunVar = 4;
        DualBlastervar = true;
        //HighScore = HighScore - 50;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void TripleBLaster(){
        gunVar = 5;
        TripleBlastervar = true;
        //HighScore = HighScore - 150;
        //PlayerPrefs.SetInt("HighScore",HighScore);
        
    }

    public void DualLauncher(){
        gunVar = 6;
        DualLaunchervar = true;
        //HighScore = HighScore - 150;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void TripleLauncher(){
        gunVar = 7;
        TripleLaunchervar = true;
        //HighScore = HighScore - 200;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void ShotgunPlus(){
        gunVar = 8;
        ShotgunPlusvar = true;
        //HighScore = HighScore - 150;
        //PlayerPrefs.SetInt("HighScore",HighScore);
    }

    public void UltimateShotgun(){
        gunVar = 9;
        UltimateShotgunvar = true;
        //HighScore = HighScore - 200;
        //PlayerPrefs.SetInt("HighScore",HighScore);

    }

}
