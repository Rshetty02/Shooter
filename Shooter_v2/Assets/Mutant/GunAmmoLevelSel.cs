using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmoLevelSel : MonoBehaviour
{
    public static int gunVar =1;

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

    public void Onebullet(){
        GunMode = 1;
    }

    public void Twobullet(){
        GunMode = 2;
    }

    public void Threebullet(){
        GunMode = 3;
    }

}
