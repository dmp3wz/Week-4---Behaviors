using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCactus : MonoBehaviour
{
    private GameObject movingDoor;
    public float maxOpen = 3.1f;
    public float maxClose = .2999897f;
    public float movementSpeed = 1f;

    bool here;
    bool opening;
       

    // Start is called before the first frame update
    void Start()
    {
        here = false;
        opening = false;
        movingDoor = GameObject.FindWithTag("Cactus");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(here){
            if(movingDoor.transform.position.x < maxOpen){
                movingDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
            else{
                movingDoor.transform.Translate(0f,0f,0f);
            }
            
        }
        else{
            if(movingDoor.transform.position.x > maxClose){
                movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            }
            else{
                movingDoor.transform.Translate(0f,0f,0f);
            }
            
        }

        //gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            here = true;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            here = false;
        }
    }
} 
