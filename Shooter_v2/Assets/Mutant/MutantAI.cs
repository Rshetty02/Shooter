using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MutantAI : MonoBehaviour
{
    public string hitTag;

    public bool lookingAtPlayer = false;

    public bool isRunning = false;

    public bool isAttacking = false;
    public GameObject theSoldier;

    public GameObject thePlayer;
    public float firerate = 0.5f;
    NavMeshAgent theAgent;

    public Vector3 Offset; 
    

    public GameObject theDestination;
    
  void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit)){
            hitTag = hit.transform.tag;
        }
        if(hitTag == "Player" && isRunning == false && isAttacking == false){
            //GameObject bulletObject = Instantiate(bullet,transform.position,transform.rotation);
            //bulletObject.transform.position = transform.position;
            StartCoroutine(EnemyRun());
            
            //EnemyRun();
            
            
        }
        if(hitTag != "Player"){
            Debug.Log("Starting Idle");
            theSoldier.GetComponent<Animator>().Play("Mutant Idle");
            theAgent.ResetPath();
            lookingAtPlayer = false;    
        }

        StartCoroutine(Attack());

    }

    //IEnumerator 
    IEnumerator  EnemyRun(){
        isRunning = true;
        Offset.Set(1,1,1);
        Debug.Log("Starting Run");
        theAgent.SetDestination(theDestination.transform.position);
        theSoldier.GetComponent<Animator>().Play("Mutant Run");
        isRunning = false;
        /*
        theSoldier.GetComponent<Animator>().Play("Fire 1Pistol",-1,0);
        theSoldier.GetComponent<Animator>().Play("Fire 1Pistol");
        //fireSound.Play();
        lookingAtPlayer = true;

        Health h = thePlayer.GetComponent<Health>();
        h.currentHealth -= 10;
        h.HandleDeath(); 
        */
        //Health.currentHealth -= 10;

        // call OnDamage action


        //Health h = thePlayer.GetComponent<Health>();
        //Health h = new Health();
        //h.TakeDamage(100,theSoldier);
        yield return new WaitForSeconds(2);
        //isRunning = false;
    }


    IEnumerator Attack(){
        if(isAttacking == true){
        Debug.Log("Attacking");
        
        this.GetComponent<Animator>().Play("Mutant Swiping");
        //this.GetComponent<Animator>().Play("Mutant Swiping",-1,0);
        yield return new WaitForSeconds(3);
        Health h = thePlayer.GetComponent<Health>();
        h.currentHealth -= 0.05f;
        h.HandleDeath(); 
        }

    }
        private void OnTriggerEnter(Collider other) {                                                                       
  
        if(other.tag == "Player" && isAttacking == false){  
        isRunning = false;
        isAttacking = true; 
        /*
        Debug.Log("Attacking");
        this.GetComponent<Animator>().Play("Mutant Swiping");
        Health h = thePlayer.GetComponent<Health>();
        h.currentHealth -= 10;
        h.HandleDeath(); 
        */
        }
        }

        void OnTriggerExit(Collider other)
        {
            if(other.tag == "Player"){
                isAttacking = false;
            }
        }
        
       



    

}