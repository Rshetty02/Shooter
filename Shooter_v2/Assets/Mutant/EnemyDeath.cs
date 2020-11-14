using System.Collections;
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
        Debug.Log(enemyHealth);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth<=0 && enemyDead == false){
            enemyDead = true;
            this.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
            theEnemy.GetComponent<LookPlayer>().enabled = false;

        }
        
    }
}
