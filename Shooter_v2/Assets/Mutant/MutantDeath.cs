using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount){
        if(PlayerInputHandler.fireButtonbool == true){
        enemyHealth -= damageAmount;
         //this.GetComponent<Animator>().Play("Damage1",-1,0);
        //this.GetComponent<Animator>().Play("Damage1");
        Debug.Log(enemyHealth);
        }

    }


     void Start() {
        if(this.tag == "warrok"){
        enemyHealth = 200; 
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth<=0 && enemyDead == false){
            enemyDead = true;
            this.GetComponent<Animator>().Play("Mutant Dying");
            //theEnemy.SetActive(false);
            theEnemy.GetComponent<MutantAI>().enabled = false;
            theEnemy.GetComponent<LookPlayer>().enabled = false;
            //theEnemy.GetComponent<BoxCollider>().enabled = false;

        }
        
    }

}
