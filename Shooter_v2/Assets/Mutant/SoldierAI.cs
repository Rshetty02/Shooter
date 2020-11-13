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

    public GameObject thePlayer;
    public float firerate = 2f;

    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit)){
            hitTag = hit.transform.tag;
        }
        if(hitTag == "Player" && isfiring == false){
            GameObject bulletObject = Instantiate(bullet,transform.position,transform.rotation);
            //bulletObject.transform.position = transform.position;
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player"){
            theSoldier.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }
    IEnumerator EnemyFire(){
        isfiring = true;
        
        theSoldier.GetComponent<Animator>().Play("Fire 1Pistol",-1,0);
        theSoldier.GetComponent<Animator>().Play("Fire 1Pistol");
        fireSound.Play();
        lookingAtPlayer = true;

        Health h = thePlayer.GetComponent<Health>();
        h.currentHealth -= 10;
        h.HandleDeath(); 

        //Health.currentHealth -= 10;

        // call OnDamage action


        //Health h = thePlayer.GetComponent<Health>();
        //Health h = new Health();
        //h.TakeDamage(100,theSoldier);
        yield return new WaitForSeconds(firerate);
        isfiring = false;
    }

}
