using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGunsAndAmmo : MonoBehaviour
{

    public int gunVar;
    //public GameObject Blaster;
    public GameObject Launcher;
    public GameObject Shotgun;
    public GameObject DualBlaster;
    public GameObject TripleBlaster;
    public GameObject ShotGunPlus;
    public GameObject UltimateShotgun;
    public GameObject DualLauncher;
    public GameObject TripleLauncher;

    public static bool DualBlastervar = GunAmmoLevelSel.DualBlastervar;
    public static bool TripleBlastervar = GunAmmoLevelSel.TripleBlastervar;
     public static bool SingleLauncher = GunAmmoLevelSel.SingleLauncher;
     public static bool DualLaunchervar = GunAmmoLevelSel.DualLaunchervar;
     public static bool TripleLaunchervar = GunAmmoLevelSel.TripleLaunchervar;
     public static bool simpleShotgun = GunAmmoLevelSel.simpleShotgun;
     public static bool ShotgunPlusvar = GunAmmoLevelSel.ShotgunPlusvar;
     public static bool UltimateShotgunvar = GunAmmoLevelSel.UltimateShotgunvar;


    public int gunMode;
    // Start is called before the first frame update
    void Start()
    {
        //gunVar = GunAmmoLevelSel.gunVar;
        //gunMode = GunAmmoLevelSel.GunMode;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(gunVar == 1){
            Blaster.SetActive(true);
            Launcher.SetActive(false);
            Shotgun.SetActive(false);
        }
        else
        */ 
        if(SingleLauncher == true){
            //Blaster.SetActive(false);
            Launcher.SetActive(true);
            //Shotgun.SetActive(false);
        }
        
        if(simpleShotgun == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            Shotgun.SetActive(true);
        }

        if(DualBlastervar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            DualBlaster.SetActive(true);
        }

        if(TripleBlastervar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            TripleBlaster.SetActive(true);
        }

        if(DualLaunchervar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            DualLauncher.SetActive(true);
        }

        if(TripleLaunchervar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            TripleLauncher.SetActive(true);
        }
        
        if(ShotgunPlusvar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            ShotGunPlus.SetActive(true);
        }

        if(UltimateShotgunvar == true){
            //Blaster.SetActive(false);
            //Launcher.SetActive(false);
            UltimateShotgun.SetActive(true);
        }
        


    }
}
