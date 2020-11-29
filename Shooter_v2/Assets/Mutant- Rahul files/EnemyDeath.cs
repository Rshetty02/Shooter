﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
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
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth<=0 && enemyDead == false){
            enemyDead = true;
            enemyAI.SetActive(false);
            this.GetComponent<Animator>().Play("Death");
            theEnemy.GetComponent<LookPlayer>().enabled = false;

        }
        
    }
}
