using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGunsAndAmmo : MonoBehaviour
{

    public int gunVar;
    //public GameObject Blaster;
    public GameObject Launcher;
    public GameObject Shotgun;

    public int gunMode;
    // Start is called before the first frame update
    void Start()
    {
        gunVar = GunAmmoLevelSel.gunVar;
        gunMode = GunAmmoLevelSel.GunMode;
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
        if(gunVar == 2){
            //Blaster.SetActive(false);
            Launcher.SetActive(true);
            Shotgun.SetActive(false);
        }
        else if(gunVar == 3){
            //Blaster.SetActive(false);
            Launcher.SetActive(false);
            Shotgun.SetActive(true);
        }


    }
}
