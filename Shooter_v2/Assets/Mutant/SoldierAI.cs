using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;

    public AudioSource fireSound;
    public bool lookingAtPlayer = false;

    public bool isfiring = false;
    public GameObject theSoldier;
    public float firerate = 1.5f;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit)){
            hitTag = hit.transform.tag;
        }
        if(hitTag == "Player" && isfiring == false){
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player"){
            theSoldier.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }
    IEnumerator EnemyFire(){
        isfiring = true;
        theSoldier.GetComponent<Animator>().Play("Fire 1Pistol");
        fireSound.Play();
        lookingAtPlayer = true;
        yield return new WaitForSeconds(firerate);
        isfiring = false;
    }

}
