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
        simpleShotgun= true;
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
        DualBlastervar = true;
    }

    public void TripleBLaster(){
        gunVar = 5;
        TripleBlastervar = true;
        
    }

    public void DualLauncher(){
        gunVar = 6;
        DualBlastervar = true;
    }

    public void TripleLauncher(){
        gunVar = 7;
        TripleLaunchervar = true;
    }

    public void ShotgunPlus(){
        gunVar = 8;
        ShotgunPlusvar = true;
    }

    public void UltimateShotgun(){
        gunVar = 9;
        UltimateShotgunvar = true;

    }

}
