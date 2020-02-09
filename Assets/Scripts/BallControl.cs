using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public int numberOfBaits;
    Rigidbody physicsForBall;
    public float velocityForBall;

    public Text scoreBoard;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        physicsForBall = GetComponent<Rigidbody>();
        scoreBoard.text = ("You ate "+counter.ToString()+"/"+numberOfBaits.ToString()+" of Baits");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int hop = 0;
        if (Input.GetKeyDown("space"))
        {
            if(transform.position.y==0.5f){
                hop = 15; 
            }
            else{
                hop = 0;
            }
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        //Debug.Log(vertical.ToString()+" -  "+ horizontal.ToString());

        Vector3 vec = new Vector3(horizontal,hop,vertical);
        hop = 0;
        physicsForBall.AddForce(vec * velocityForBall);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Bait"){
            Destroy(other.gameObject);
            counter += 1;
            scoreBoard.text = ("You ate "+counter.ToString()+"/"+numberOfBaits.ToString()+" of Baits");
            if(counter == numberOfBaits){
                 scoreBoard.text =("You ate every thing on the game!");
            }
        }
    }
    
}
