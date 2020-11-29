using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmoLevelSel : MonoBehaviour
{
    public static int gunVar =1;

    public static bool DualBlaster = false;

    public static bool TripleBlaster = false;

    public static bool SingleLauncher = false;
    public static bool DualLauncher = false;
    public static bool TripleLauncher = false;
    public static bool simpleShotgun = false;
    public static bool ShotgunPlus = false;
    public static bool UltimateShotgn = false;


    public static int levelVar =1;

    public static int GunMode = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GunSelectionBlaster(){
    gunVar = 1;

    }

    public void GunSelectionLauncher(){
        gunVar = 2;
        SingleLauncher = true;
    }

    public void GunSelectionShotGun(){
        gunVar = 3;
    }

    public void FirstLevel(){
        levelVar =1;
    }

    public void SecondLevel(){
        levelVar = 2;
    }

    public void ThirdLevel(){
        levelVar = 3;
    }

    public void DualBlaster(){
        gunVar = 4;
    }

    public void TripleBLaster(){
        gunVar = 5;
    }

    public void DualLauncher(){
        gunVar = 6;
    }

    public void TripleLaunvcher(){
        gunVar = 7;
    }

    public void ShotgunPlus(){
        gunVar = 8;
    }

    public void UltimateShotgun(){
        gunVar = 9;
    }

}
