using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //PUBLIC VARIABLE
    public float speed = 2;
    public float jumpSpeed = 500;

    //PRIVATE VARIABLES
    private Rigidbody2D rBody;
    private bool canJump = true;
    

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // // Update is called once per frame
    void Update()
    {
        //Space click
        
        if(Input.GetKeyDown(KeyCode.Space) && canJump){
            rBody.AddForce(new Vector2(0,jumpSpeed));
            canJump = false;
        }


        //raycast rom your feet downwards towards the ground
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.name == "CoinSprite")
        {
            Destroy(col.gameObject);
        }
        canJump = true;
    }
    
    // void OnCollisionExit (Collision col)
    // {
    //     if(col.gameObject.name == "GrassSprite")
    //     {
    //         canJump = false;
    //     }
    // }

    

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// Use fixed update for phyics based movement only
    ///
    ///</summary>
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        // float vert = Input.GetAxis("Vertical");



        float currentVelocityY = rBody.velocity.y;

        if(canJump){
            rBody.velocity = new Vector2(horiz*speed,currentVelocityY);
        }
        else{
            rBody.velocity = new Vector2(horiz*speed,currentVelocityY);
        }
    }
}
